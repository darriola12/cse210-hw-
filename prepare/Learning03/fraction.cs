using System;

public class Fraction
{
    private int _Top;
    private int _Botton;

    public Fraction()
    {   
        _Top = 1;
        _Botton = 1;
    }
    public Fraction( int number)
    {
        _Top = number;
        _Botton = 1;
    }
    public Fraction(int top, int botton)
    {
        _Top = top;
        _Botton = botton;
    
    }

    public string Getfraction()
    {
        string text = $"{_Top} / {_Botton}";
        return text;
    }
    public double GetfractionDeciamls()
    {
        return (double) _Top / (double) _Botton;
    
    }



}
