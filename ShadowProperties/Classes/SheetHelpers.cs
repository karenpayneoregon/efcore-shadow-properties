using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowProperties.Classes;
internal class SheetHelpers
{
    /// <summary>
    /// Does a worksheet exists in an Excel file
    /// </summary>
    /// <param name="document">Instance of a <see cref="SLDocument"/></param>
    /// <param name="sheetName">Sheet name to determine if it exists in <see cref="document"/></param>
    /// <returns></returns>
    public static bool SheetExists(SLDocument document, string sheetName)
        => document.GetSheetNames(false).Any((name)
            => string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase));

    /// <summary>
    /// Get all sheet names in an Excel file
    /// </summary>
    /// <param name="fileName">Existing Excel file without a password</param>
    /// <returns>Sheet names in ordinal order</returns>
    /// <remarks>
    /// Both OleDb and automation return sheet names in A-Z order
    /// </remarks>
    public static List<string> SheetNames(string fileName)
    {
        using var document = new SLDocument(fileName);
        return document.GetSheetNames(false);
    }
    public delegate void OnErrorDelegate(Exception exception);
    public static event OnErrorDelegate OnErrorEvent;
    public static bool RemoveWorkSheet(string fileName, string sheetName)
    {
        using var document = new SLDocument(fileName);
        var workSheets = document.GetSheetNames(false);

        if (workSheets.Any((name) => string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase)))
        {

            if (workSheets.Count > 1)
            {
                document.SelectWorksheet(document.GetSheetNames().FirstOrDefault((name) => !string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase)));
            }
            else if (workSheets.Count == 1)
            {
                OnErrorEvent?.Invoke(new Exception("Can not delete the sole worksheet"));
            }

            document.DeleteWorksheet(sheetName);
            document.Save();

            return true;

        }
        else
        {
            return false;
        }
    }
    public static bool AddNewSheet(string fileName, string sheetName)
    {

        using var document = new SLDocument(fileName);

        if (!(SheetExists(document, sheetName)))
        {

            document.AddWorksheet(sheetName);
            document.Save();

            return true;

        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Create a new Excel file, rename the default sheet from
    /// Sheet1 to the value in pSheetName
    /// </summary>
    /// <param name="pFileName"></param>
    /// <param name="pSheetName"></param>
    /// <returns></returns>
    public bool CreateNewFile(string pFileName, string pSheetName)
    {
        using var document = new SLDocument();
        document.RenameWorksheet("Sheet1", pSheetName);
        document.SaveAs(pFileName);
        return true;
    }
    /// <summary>
    /// Get last row in <see cref="pFileName"/> for <see cref="pSheetName"/>
    /// </summary>
    /// <param name="pFileName">Existing file name</param>
    /// <param name="pSheetName">Existing sheet</param>
    /// <returns>Last row or zero</returns>
    /// <remarks>
    /// if unsure if sheet exists use <see cref="SheetExists"/> first
    /// </remarks>
    public int GetWorkSheetLastRow(string pFileName, string pSheetName)
    {


        using var document = new SLDocument(pFileName, pSheetName);

        /*
         * get statistics, in this case we want the last used row so we
         * simply index into EndRowIndex yet there are more properties.
         */

        return document.GetWorksheetStatistics().EndRowIndex;

    }

    public static void ExportToExcel(DataTable table, string fileName, bool includeHeader, string sheetName)
    {
        using var document = new SLDocument();

        // import to first row, first column
        document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, includeHeader);

        // give sheet a useful name
        document.RenameWorksheet(SLDocument.DefaultFirstSheetName, sheetName);

        document.SaveAs(fileName);
    }
}

/// <summary>
/// Common extensions 
/// </summary>
public static class SheetExtensions
{

    /// <summary>
    /// Same as in SheetHelpers while in this case it's an extension method
    /// </summary>
    /// <param name="document"></param>
    /// <param name="sheetName"></param>
    /// <returns></returns>
    public static bool SheetExists(this SLDocument document, string sheetName) =>
        document.GetSheetNames(false).Any((name) =>
            string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase));

}