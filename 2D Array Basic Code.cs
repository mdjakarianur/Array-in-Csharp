using System;

namespace MultiDArray {
  class Program {
    static void Main(string[] args) {
           
        //initializing 2D array
       int[ , ] numbers = {{2, 3}, {4, 5}};
 	 
        // access first element from the first row
       Console.WriteLine("Element at index [0, 0] : "+numbers[0, 0]);
  	 
        // access first element from second row
       Console.WriteLine("Element at index [1, 0] : "+numbers[1, 0]);
    }
  }
}
