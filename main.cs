using System;

class MainClass {
  public static void Main (string[] args) {
    // Get input
    Console.WriteLine ("Enter First Number");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Enter Second Number");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    // Calculate and display
   int sum = firstNumber + secondNumber;
   Console.WriteLine("Sum: " + sum);
   int difference = firstNumber - secondNumber;
   Console.WriteLine("Difference: " + difference);
   int product = firstNumber * secondNumber;
   Console.WriteLine("Product: " + product);
   double quotient = firstNumber / secondNumber;
   Console.WriteLine("Quotient: " + quotient);
   double remainder = firstNumber % secondNumber;
   Console.WriteLine("Remainder: " + remainder);
  }
}