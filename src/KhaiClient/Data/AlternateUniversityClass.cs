namespace Khai;

public class AlternateUniversityClass
{
    public UniversityClass? Numerator { get; set; }
    public UniversityClass? Denominator { get; set; }

    public AlternateUniversityClass(UniversityClass? numerator, UniversityClass? denominator)
    {
        Numerator   = numerator;
        Denominator = denominator;
    }
}
