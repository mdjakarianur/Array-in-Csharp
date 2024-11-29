using System;

namespace MultiDArray {
  class Program  {
    static void Main(string[] args)  {

      int[ , ] numbers = { {2, 3, 9}, {4, 5, 9} };
   	 
      for(int i = 0; i < numbers.GetLength(0); i++)  { 
        Console.Write("Row "+ i+": ");

        for(int j = 0; j < numbers.GetLength(1); j++)  { 
          Console.Write(numbers[i, j]+" ");
 
        }
        Console.WriteLine(); 
  
      }  
    }
  }
}
