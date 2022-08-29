namespace SeCli.libse.Common.TextLengthCalculator
{
    public interface ICalcLength
    {
        decimal CountCharacters(string text, bool forCps);
    }
}