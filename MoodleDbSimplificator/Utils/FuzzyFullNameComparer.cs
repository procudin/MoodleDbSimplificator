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
        var xSpan = Regexes.SingleWhitespace().Match(x) is { Success: true } xMatch
            ? x.AsSpan(0, xMatch.Index)
            : x.AsSpan();
        var ySpan = Regexes.SingleWhitespace().Match(y) is { Success: true } yMatch
            ? y.AsSpan(0, yMatch.Index)
            : y.AsSpan();
        if (!xSpan.EqualsRu(ySpan))
            return false;
            
        // фамилии совпали = проверяем по нечеткому сравнению
        return Fuzz.PartialRatio(x, y) > 97;
    }
    
    public int GetHashCode(string obj)
    {
        // расчитываем хэш чисто по фамилии
        var span = Regexes.SingleWhitespace().Match(obj) is { Success: true } match
            ? obj.AsSpan(0, match.Index)
            : obj.AsSpan();
        return span.GetHashCodeRu();
    }
}
