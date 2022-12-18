using System;
using System.Collections.Generic;

namespace Khai;

public class DaySchedule
{
    private IList<AlternateUniversityClass> _classes = new List<AlternateUniversityClass>();

    public IList<AlternateUniversityClass> Classes
    {
        get => _classes;
        set => _classes = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DaySchedule() { }

    public DaySchedule(IList<AlternateUniversityClass> classes)
    {
        Classes = classes;
    }
}
