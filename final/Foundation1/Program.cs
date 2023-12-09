using System;
 class Program
  {

    static void Main(string[] args)
    {
         
        Shape s = new Square(8);
       
        double result = s.area();
         
        Console.Write("{0}", result);
  
    }
  }
