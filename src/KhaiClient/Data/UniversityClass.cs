using System;

namespace Khai;

public class UniversityClass
{
    private string _name = string.Empty;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
    public string? RoomNumber { get; set; }

    public UniversityClass() { }

    public UniversityClass(string name)
    {
        Name = name;
    }

    public UniversityClass(string name, string? roomNumber) : this(name)
    {
        RoomNumber = roomNumber;
    }
}
