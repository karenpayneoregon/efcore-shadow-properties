using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShadowProperties.Data;

namespace ShadowProperties.Classes;
public static class DbContextHelper
{
    public static DbContextOptions<ShadowContext> GetDbContextOptions()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<ShadowContext>();
        
        return new DbContextOptionsBuilder<ShadowContext>()
            .UseSqlServer(new SqlConnection(configuration
                .GetConnectionString("DefaultConnection")))
            .Options;

    }
}
