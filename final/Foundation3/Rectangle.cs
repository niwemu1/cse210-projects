using System;

class Rectangle : RegularPolygon
{

    public int length = 400;
    public int breadth = 800;
    public int sides = 4;

    public void calculateArea() {
    
      int area = length * breadth;
      Console.WriteLine("Area of Rectangle: " + area);
    }
}