using System;
using System.Collections.Generic;
using System.Linq;

namespace Khai;

public static class EnumerableExtensions
{
    public static IEnumerable<TSource[]> SplitBy<TSource>(
        this IEnumerable<TSource> source, TSource[] separators, IEqualityComparer<TSource>? comparer = null)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(separators);
        
        return SplitByIterator(source, separators, comparer);
    }

    private static IEnumerable<TSource[]> SplitByIterator<TSource>(
        this IEnumerable<TSource> source, TSource[] separators, IEqualityComparer<TSource>? comparer)
    {
        comparer ??= EqualityComparer<TSource>.Default;

        var current = new List<TSource>();

        foreach (var item in source)
        {
            if (separators.Contains(item, comparer))
            {
                if (current.Count > 0)
                {
                    yield return current.ToArray();
                    current = new List<TSource>();
                }
            }
            else
            {
                current.Add(item);
            }
        }

        if (current.Count > 0)
            yield return current.ToArray();
    }
}
