using System;
using System.Collections;
using System.Collections.Generic;

namespace Khai;

public class WeekSchedule : IEnumerable<DaySchedule>
{
    public DaySchedule Monday { get; }
    public DaySchedule Tuesday { get; }
    public DaySchedule Wednesday { get; }
    public DaySchedule Thursday { get; }
    public DaySchedule Friday { get; }

    public WeekSchedule(DaySchedule monday, DaySchedule tuesday,
        DaySchedule wednesday, DaySchedule thursday, DaySchedule friday)
    { 
        Monday    = monday ?? throw new ArgumentNullException(nameof(monday));
        Tuesday   = tuesday ?? throw new ArgumentNullException(nameof(tuesday));
        Wednesday = wednesday ?? throw new ArgumentNullException(nameof(wednesday));
        Thursday  = thursday ?? throw new ArgumentNullException(nameof(thursday));
        Friday    = friday ?? throw new ArgumentNullException(nameof(friday));
    }

    public static WeekSchedule Parse(IList<DaySchedule> daySchedules)
    {
        ArgumentNullException.ThrowIfNull(daySchedules);

        if (daySchedules.Count != 5)
            throw new ArgumentException("A day schedules count must equals 5.");

        return new WeekSchedule(daySchedules[0], daySchedules[1], daySchedules[2], daySchedules[3], daySchedules[4]);
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
