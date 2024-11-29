using System;

namespace AccessArrayFor {
  class Program {
    static void Main(string[] args) {

      int[] numbers = { 1, 2, 3};
 	 
      for(int i=0; i < numbers.Length; i++) {
        Console.WriteLine("Element in index " + i + ": " + numbers[i]);
      }

      Console.ReadLine();
    }
  }
}
