using System;

namespace MultiDArray {
  class Program {
    static void Main(string[] args) {

    int[ , ] numbers = {{2, 3}, {4, 5}};
 	 
     // old element
    Console.WriteLine("Old element at index [0, 0] : "+numbers[0, 0]);
 	 
      // assigning new value
    numbers[0, 0] = 222;
  	 
      // new element
    Console.WriteLine("New element at index [0, 0] : "+numbers[0, 0]);
    }
  }
}
