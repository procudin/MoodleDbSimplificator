namespace MoodleDbSimplificator.Utils;

public static class RuStringExtensions
{
    public static bool EqualsRu(this ReadOnlySpan<char> first, ReadOnlySpan<char> second)
    {
        if (first.Length != second.Length)
            return false;
        for(var i = 0; i < first.Length; ++i)
        {
            var (xi, yi) = (char.ToLower(first[i]), char.ToLower(second[i]));
            if (xi != yi && !(xi is 'е' or 'ё' && yi is 'е' or 'ё'))
                return false;
        }
        return true;
    }

    public static int GetHashCodeRu(this ReadOnlySpan<char> span)
    {
        unchecked
        {
            int hash1 = 5381;
            int hash2 = hash1;
    
            for (int i = 0; i < span.Length && span[i] != '\0'; i += 2)
            {
                var spani = char.ToLower(span[i]);
                if (spani == 'ё')
                    spani = 'е';
                    
                hash1 = ((hash1 << 5) + hash1) ^ spani;
                if (i == span.Length - 1 || span[i + 1] == '\0')
                    break;
                var spani1 = char.ToLower(span[i + 1]);
                if (spani1 == 'ё')
                    spani1 = 'е';
                hash2 = ((hash2 << 5) + hash2) ^ spani1;
            }
    
            return hash1 + (hash2 * 1566083941);
        }
    }
}
