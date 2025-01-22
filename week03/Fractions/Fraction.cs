using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    //Constructor with no perameters

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    //constructor with one parameter
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    //constructor with two parameters for numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        
        _numerator = numerator;
        _denominator = denominator;
    }

    
    //GetFractionString method
    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}