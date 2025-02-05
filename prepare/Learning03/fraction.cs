using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // needs to set a default
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // show the numbers as a fraction, but does not compute the actual value
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        //finds the decimal value. Needs to be able to do decimals.
        return (double)_top / (double)_bottom;
    }
}