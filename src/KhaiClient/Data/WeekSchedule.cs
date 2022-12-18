using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Khai;

public class WeekSchedule
{
    private DaySchedule[] _days;

    public DaySchedule Monday
    {
        get => _days[0];
        set => _days[0] = value ?? throw new ArgumentNullException(nameof(value));
    }
    public DaySchedule Tuesday
    {
        get => _days[1];
        set => _days[1] = value ?? throw new ArgumentNullException(nameof(value));
    }
    public DaySchedule Wednesday
    {
        get => _days[2];
        set => _days[2] = value ?? throw new ArgumentNullException(nameof(value));
    }
    public DaySchedule Thursday
    {
        get => _days[3];
        set => _days[3] = value ?? throw new ArgumentNullException(nameof(value));
    }
    public DaySchedule Friday
    {
        get => _days[4];
        set => _days[4] = value ?? throw new ArgumentNullException(nameof(value));
    }

    public WeekSchedule() : this(new(), new(), new(), new(), new()) { }

    public WeekSchedule(DaySchedule monday, DaySchedule tuesday,
        DaySchedule wednesday, DaySchedule thursday, DaySchedule friday)
    {
        ArgumentNullException.ThrowIfNull(monday);
        ArgumentNullException.ThrowIfNull(tuesday);
        ArgumentNullException.ThrowIfNull(wednesday);
        ArgumentNullException.ThrowIfNull(thursday);
        ArgumentNullException.ThrowIfNull(friday);

        _days = new DaySchedule[5] { monday, tuesday, wednesday, thursday, friday };
    }

    public static WeekSchedule Parse(IList<DaySchedule> days)
    {
        ArgumentNullException.ThrowIfNull(days);

        if (days.Count != 5)
            throw new ArgumentException("The days count must equals 5.");

        return new WeekSchedule(days[0], days[1], days[2], days[3], days[4]);
    }

    public IList<DaySchedule> AsDays() => new ReadOnlyCollection<DaySchedule>(_days);
}
