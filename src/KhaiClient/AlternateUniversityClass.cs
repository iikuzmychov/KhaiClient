namespace Khai;

public class AlternateUniversityClass
{
    public UniversityClass? Numerator { get; }
    public UniversityClass? Denominator { get; }

    public AlternateUniversityClass(UniversityClass? numerator, UniversityClass? denominator)
    {
        Numerator   = numerator;
        Denominator = denominator;
    }
}
