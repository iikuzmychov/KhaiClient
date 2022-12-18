using System;
using System.Collections;
using System.Collections.Generic;

namespace Khai;

public class DaySchedule : IEnumerable<AlternateUniversityClass>
{
    public IList<AlternateUniversityClass> Classes { get; }

    public DaySchedule() : this(new List<AlternateUniversityClass>()) { }

    public DaySchedule(IList<AlternateUniversityClass> classes)
    {
        Classes = classes ?? throw new ArgumentNullException(nameof(classes));
    }

    IEnumerator<AlternateUniversityClass> IEnumerable<AlternateUniversityClass>.GetEnumerator()
        => Classes.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => Classes.GetEnumerator();
}
