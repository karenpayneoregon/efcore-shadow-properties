using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ShadowProperties.Models;

namespace ShadowProperties.Classes;
public class DataOperations
{
    private static IConfigurationRoot ConfigurationRoot() =>
        new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables()
            .Build();


    private static string ConnectionString 
        => ConfigurationRoot().GetSection("ConnectionStrings:DefaultConnection").Value;

    /// <summary>
    /// Get count of records marked as soft delete
    /// </summary>
    /// <returns>Count of soft deleted records</returns>
    public static async Task<int> IgnoreCount()
    {
        await using SqlConnection cn = new(ConnectionString);
        await using SqlCommand cmd = new()
        {
            Connection = cn,
            CommandText = "SELECT COUNT(ContactId) FROM dbo.Contact1 WHERE isDeleted = @p1"
        };
        cmd.Parameters.Add("@p1", SqlDbType.Int).Value = 1;
        await cn.OpenAsync();
        return (int)cmd.ExecuteScalar()!;
    }

    /// <summary>
    /// View for all contacts
    /// </summary>
    public static async Task<List<Report>> Reports()
    {
        string command =
            """
            SELECT ContactId,
                   FirstName,
                   LastName,
                   LastUser,
                   CreatedBy,
            	   FORMAT(CreatedAt, 'MM/dd/yyyy') AS CreatedAt,
            	   FORMAT(LastUpdated, 'MM/dd/yyyy') AS LastUpdated,
                   IIF(isDeleted = 'TRUE' , 'Y','N') AS Deleted
            FROM dbo.Contact1;
            """;

        await using SqlConnection cn = new(ConnectionString);
        await using SqlCommand cmd = new() { Connection = cn, CommandText = command };

        await cn.OpenAsync();

        var reader = await cmd.ExecuteReaderAsync();

        var list = new List<Report>();

        while (reader.Read())
        {
            list.Add(new Report
            {
                ContactId = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                LastUser = reader.GetString(3),
                CreatedBy = reader.GetString(4),
                CreatedAt = reader.GetString(5),
                LastUpdated = reader.GetString(6),
                Deleted = reader.GetString(7)
            });
        }

        return list;

    }
}
