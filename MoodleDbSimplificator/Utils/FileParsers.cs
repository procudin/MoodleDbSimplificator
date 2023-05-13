using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Text;

namespace MoodleDbSimplificator.Utils;

public class TotalTableElement
{
    [Name("Физическое лицо")]
    public required string FullName { get; set; }
    [Name("Отметка")]
    public required string Grade { get; set; }
}

public static class Parsers
{
    public static List<TotalTableElement> ParseCsvWithTotalTable(string pathToCsv)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            NewLine = Environment.NewLine,
            Delimiter = ";",
            TrimOptions = TrimOptions.Trim,
        };
        using var reader = new StreamReader(pathToCsv, Encoding.UTF8);
        using var csv = new CsvReader(reader, config);
        var records = csv.GetRecords<TotalTableElement>();
        return records.ToList();
    }
}
