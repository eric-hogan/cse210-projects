public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {

        _top = 1;
        _bottom = 1;

    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;


    }

    public Fraction(int topNum, int bottomNum)
    {
        _top = topNum;
        _bottom = bottomNum;


    }

    public string GetFractionString()
    {
        string fractionString = $"{_top} / {_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}


