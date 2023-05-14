using System.Text.RegularExpressions;

namespace MoodleDbSimplificator.Utils;

/// <summary>
/// Компаратор, сравнивающий строки только по первому слову
/// </summary>
public class FirstWordComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x == null && y == null)
            return true;
        if (x == null || y == null)
            return false;

        // сначала проверям по совпадении с фамилией, которая идет первой
        var xSpan = Regexes.SingleWhitespace().Match(x) is { Success: true } xMatch
            ? x.AsSpan(0, xMatch.Index)
            : x.AsSpan();
        var ySpan = Regexes.SingleWhitespace().Match(y) is { Success: true } yMatch
            ? y.AsSpan(0, yMatch.Index)
            : y.AsSpan();
        return xSpan.EqualsRu(ySpan);
    }
    
    public int GetHashCode(string obj)
    {
        // расчитываем хэш чисто по фамилии, игнорируем букву 'ё'
        var span = Regexes.SingleWhitespace().Match(obj) is { Success: true } match
            ? obj.AsSpan(0, match.Index)
            : obj.AsSpan();
        return span.GetHashCodeRu();
    }
}
