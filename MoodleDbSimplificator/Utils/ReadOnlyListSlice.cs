using System.Collections;

namespace MoodleDbSimplificator.Utils;

public class ReadOnlyListSlice<T> : IReadOnlyList<T>
{
    private readonly IReadOnlyList<T> _list;
    private readonly int _startIndex;
    private readonly int _inclusiveEndIndex;
    
    public ReadOnlyListSlice(IReadOnlyList<T> list, int startIndex, int inclusiveEndIndex)
    {
        //if (startIndex < 0)
        //    throw new ArgumentException("Invalid startIndex", nameof(startIndex));
        //if (inclusiveEndIndex < 0 || inclusiveEndIndex >= list.Count || inclusiveEndIndex < startIndex)
        //    throw new ArgumentException("Invalid inclusiveEndIndex", nameof(inclusiveEndIndex));
        
        _list              = list;
        _startIndex        = startIndex;
        _inclusiveEndIndex = inclusiveEndIndex;
    }
    
    public ReadOnlyListSlice(IReadOnlyList<T> list, int startIndex)
        : this(list, startIndex, list.Count - 1)
    {
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = _startIndex; i <= _inclusiveEndIndex; ++i)
            yield return _list[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count => _inclusiveEndIndex - _startIndex;

    public T this[int index] => _list[index+_startIndex];
}
