using System;
using System.Collections;
using System.Collections.Generic;

namespace Khai;

public class WeekSchedule : IEnumerable<DaySchedule>
{
    private DaySchedule _monday = new();
    private DaySchedule _tuesday = new();
    private DaySchedule _wednesday = new();
    private DaySchedule _thursday = new();
    private DaySchedule _friday = new();

    public DaySchedule Monday
    {
        get => _monday;
        set => _monday = value ?? throw new ArgumentNullException(nameof(value));
    }
    public DaySchedule Tuesday
    {
        get => _tuesday;
        set => _tuesday = value ?? throw new ArgumentNullException(nameof(value));
    }
    public DaySchedule Wednesday
    {
        get => _wednesday;
        set => _wednesday = value ?? throw new ArgumentNullException(nameof(value));
    }
    public DaySchedule Thursday
    {
        get => _thursday;
        set => _thursday = value ?? throw new ArgumentNullException(nameof(value));
    }
    public DaySchedule Friday
    {
        get => _friday;
        set => _friday = value ?? throw new ArgumentNullException(nameof(value));
    }

    public WeekSchedule() { }

    public WeekSchedule(DaySchedule monday, DaySchedule tuesday,
        DaySchedule wednesday, DaySchedule thursday, DaySchedule friday)
    { 
        Monday    = monday;
        Tuesday   = tuesday;
        Wednesday = wednesday;
        Thursday  = thursday;
        Friday    = friday;
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
