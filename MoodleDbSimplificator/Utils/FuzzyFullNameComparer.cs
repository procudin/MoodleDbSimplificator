using FuzzySharp;

namespace MoodleDbSimplificator.Utils;

public class FuzzyFullNameComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x == null && y == null)
            return true;
        if (x == null || y == null)
            return false;
    
        // сначала проверям по совпадении с фамилией, которая идет первой
        var xSpan = Regexes.Whitespaces().Match(x) is { Success: true } xMatch
            ? x.AsSpan(0, xMatch.Index + xMatch.Length - 1)
            : x.AsSpan();
        var ySpan = Regexes.Whitespaces().Match(y) is { Success: true } yMatch
            ? y.AsSpan(0, yMatch.Index + yMatch.Length - 1)
            : y.AsSpan();
        if (!xSpan.EqualsRu(ySpan))
            return false;
            
        // фамилии совпали = проверяем по нечеткому сравнению
        return Fuzz.PartialRatio(x, y) > 97;
    }
    
    public int GetHashCode(string obj)
    {
        // расчитываем хэш чисто по фамилии
        var span = Regexes.Whitespaces().Match(obj) is { Success: true } match
            ? obj.AsSpan(0, match.Index + match.Length - 1)
            : obj.AsSpan();
        return span.GetHashCodeRu();
    }
}
