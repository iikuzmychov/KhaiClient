using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Khai;

public class DaySchedule : IEnumerable<AlternateUniversityClass>
{
    public ReadOnlyCollection<AlternateUniversityClass> Classes { get; }

    public DaySchedule(IList<AlternateUniversityClass> classes)
    {
        ArgumentNullException.ThrowIfNull(classes);

        if (classes.Count <= 0)
            throw new ArgumentException("A classes count must be greater 0.");

        Classes = new(classes);
    }

    IEnumerator<AlternateUniversityClass> IEnumerable<AlternateUniversityClass>.GetEnumerator()
        => Classes.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => Classes.GetEnumerator();
}
