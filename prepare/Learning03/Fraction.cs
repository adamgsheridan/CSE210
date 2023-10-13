public class Fraction
{

    // Makes two attributes to represent the top and bottom of a fraction.
    private int _top;
    private int _bottom;

    // Constructor to make the fraction 1/1. Used when there are no parameters.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor to make a fraction that is a guaranteed whole number
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor to make a fraction with two parameters. Top and bottom.
    public Fraction(int wholeNumber1, int wholeNumber2)
    {
        _top = wholeNumber1;
        _bottom = wholeNumber2;
    }

    // Getter to format the top and bottom numbers into fraction form.
    public string GetFractionString()
    {
        string numberFraction = $"{_top}/{_bottom}";
        return numberFraction;
    }

    // Getter to format the top and bottom numbers into a decimal form.
    public double GetDecimalValue()
    {
        double numberDecimal = (double)_top / (double)_bottom;
        return numberDecimal;
    }
}