using System;
using System.Collections;
using System.Collections.Generic;

namespace KhaiApiClient;

public class DaySchedule : IEnumerable<AlternateUniversityClass>
{
    public AlternateUniversityClass First { get; }
    public AlternateUniversityClass Second { get; }
    public AlternateUniversityClass Third { get; }
    public AlternateUniversityClass Fourth { get; }

    public DaySchedule(AlternateUniversityClass first, AlternateUniversityClass second,
        AlternateUniversityClass third, AlternateUniversityClass fourth)
    {
        First  = first ?? throw new ArgumentNullException(nameof(first));
        Second = second ?? throw new ArgumentNullException(nameof(second));
        Third  = third ?? throw new ArgumentNullException(nameof(third));
        Fourth = fourth ?? throw new ArgumentNullException(nameof(fourth));
    }

    IEnumerator<AlternateUniversityClass> IEnumerable<AlternateUniversityClass>.GetEnumerator()
    {
        yield return First;
        yield return Second;
        yield return Third;
        yield return Fourth;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        yield return First;
        yield return Second;
        yield return Third;
        yield return Fourth;
    }
}
