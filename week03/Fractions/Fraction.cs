public class Fraction
{
    private int _top;
    private int _bottom;

    public int GetTopNumber()
    {
        return _top;
    }

    public void SetTopNumber (int topNum)
    {
        _top = topNum;
    }

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top} / {_bottom}");
    }

    public Fraction (int topNum)
    {
        _top = topNum;
        _bottom = 1;
        Console.WriteLine($"{_top} / {_bottom}");

    }

    public Fraction(int topNum, int bottomNum)
    {
        _top = topNum;
        _bottom = bottomNum;
        Console.WriteLine($"{_top} / {_bottom}");
        
    }
}


