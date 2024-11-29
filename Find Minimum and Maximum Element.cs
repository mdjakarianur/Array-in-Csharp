using System;

 // provides us various methods to use in an array
using System.Linq;

namespace ArrayMinMax {
  class Program  {
    static void Main(string[] args) {

      int[] numbers = {51, 1, 3, 4, 98};

      // get the minimum element
      Console.WriteLine("Smallest  Element: " + numbers.Min());  

      // Max() returns the largest number in array
      Console.WriteLine("Largest Element: " + numbers.Max());  
 	 
      Console.ReadLine();
    }
  }
}
