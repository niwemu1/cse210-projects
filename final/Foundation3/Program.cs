using System;
class Program
{

    static void Main(string[] args) {

      Square s1 = new Square();
      s1.calculateArea();
      s1.calculatePerimeter(s1.length, s1.sides);
      

      Rectangle r1 = new Rectangle();
      r1.calculateArea();
      r1.calculatePerimeter( r1.length, r1.sides );
      
    }
}
     