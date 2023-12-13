using System;

class Square : RegularPolygon
{

    public int  length = 500;
    public int sides = 4;
    public void calculateArea() 
    {
      int area = length * length;
      Console.WriteLine("Area of Square: " + area);
    }
}