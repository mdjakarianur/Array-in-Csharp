using System;

namespace ChangeArray {
  class Program {
    static void Main(string[] args) {

      // create an array
      int[] numbers = {1, 2, 3};

      Console.WriteLine("Old Value at index 0: " + numbers[0]);

      // change the value at index 0
      numbers[0] = 11;

      //print new value
      Console.WriteLine("New Value at index 0: " + numbers[0]);

      Console.ReadLine();
    }
  }
}
