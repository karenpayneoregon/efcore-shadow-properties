using System.Data;
using DocumentFormat.OpenXml.Spreadsheet;
using FastMember;
using SpreadsheetLight;
using Color = System.Drawing.Color;

namespace ShadowProperties.Classes;
public class ExcelOperations
{
    public static DataTable ToDataTable<T>(IReadOnlyList<T> sender)
    {
        DataTable table = new();
        using var reader = ObjectReader.Create(sender);
        table.Load(reader);

        return table;
    }

    public static bool ExportToExcel<T>(IReadOnlyList<T> list)
    {
        DataTable table = ToDataTable<T>(list);

        try
        {
            for (int index = 0; index < table.Columns.Count; index++)
            {
                table.Columns[index].ColumnName = table.Columns[index].ColumnName.SplitCamelCase();
            }

            using var document = new SLDocument();

            document.DocumentProperties.Creator = "Karen Payne";
            document.DocumentProperties.Title = "Deleted reports";
            document.DocumentProperties.Category = "ABC Contacts";

            // define first row style
            var headerStyle = HeaderStye(document);

            /*
             * Import DataTable starting at A1, include column headers
             */
            document.ImportDataTable(1, SLConvert.ToColumnIndex("A"), table, true);
            document.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Deleted report for contacts");
            var columnCount = table.Columns.Count;
            document.SetCellStyle(1, 1, 1, columnCount, headerStyle);

            for (int columnIndex = 1; columnIndex < columnCount + 1; columnIndex++)
            {
                document.AutoFitColumn(columnIndex);
            }
            
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                $"DeletedReport{DateTime.Now:yyyy-MM-dd HH-mm-ss}.xlsx");

            document.SetActiveCell("A2");

            document.SaveAs(fileName);
            return true;
        }
        catch 
        {
            /*
             * Basic reason for failure
             * 1. Developer error
             * 2. User has file open in Excel but here that is not possible because of the file name
             */
            return false;
        }
    }
    /// <summary>
    /// Style for first row in the Excel file
    /// </summary>
    public static SLStyle HeaderStye(SLDocument document)
    {

        SLStyle headerStyle = document.CreateStyle();

        headerStyle.Font.Bold = true;
        headerStyle.Font.FontColor = Color.White;
        headerStyle.Fill.SetPattern(
            PatternValues.LightGray,
            SLThemeColorIndexValues.Accent1Color,
            SLThemeColorIndexValues.Accent5Color);

        return headerStyle;
    }
}
