using System;
using System.Collections;
using System.Collections.Generic;

namespace KhaiApiClient;

public class Schedule : IEnumerable<DaySchedule>
{
    public DaySchedule Monday { get; }
    public DaySchedule Tuesday { get; }
    public DaySchedule Wednesday { get; }
    public DaySchedule Thursday { get; }
    public DaySchedule Friday { get; }

    public Schedule(DaySchedule monday, DaySchedule tuesday,
        DaySchedule wednesday, DaySchedule thursday, DaySchedule friday)
    { 
        Monday    = monday ?? throw new ArgumentNullException(nameof(monday));
        Tuesday   = tuesday ?? throw new ArgumentNullException(nameof(tuesday));
        Wednesday = wednesday ?? throw new ArgumentNullException(nameof(wednesday));
        Thursday  = thursday ?? throw new ArgumentNullException(nameof(thursday));
        Friday    = friday ?? throw new ArgumentNullException(nameof(friday));
    }

    IEnumerator<DaySchedule> IEnumerable<DaySchedule>.GetEnumerator()
    {
        yield return Monday;
        yield return Tuesday;
        yield return Wednesday;
        yield return Thursday;
        yield return Friday;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        yield return Monday;
        yield return Tuesday;
        yield return Wednesday;
        yield return Thursday;
        yield return Friday;
    }
}
