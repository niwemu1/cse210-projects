using System;

class Rectangle : RegularPolygon
{

    public int length = 200;
    public int breadth = 500;
    public int sides = 4;

    public void calculateArea() {
    
      int area = length * breadth;
      Console.WriteLine("Area of Rectangle: " + area);
    }
}