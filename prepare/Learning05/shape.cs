using System;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
       _color = color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();// itd because this wont be needed at all so we give it the abstract trait.
}