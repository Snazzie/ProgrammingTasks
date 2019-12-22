using System;

namespace SimpleCalculator
{
    class Program
    {

        // TASK
        // Write a simple console app calculator that takes a simple equation as an input and returns the answer. eg. "2*10" should return 20
        // Use the test project to verify you have achieved 

        // Tips
        // 1.
        // Dont worry about working with console just yet. start by making the Calculate method working
        // Use the test in SimpleCalculatorTests to verify it is working
        //
        // 2.
        // Methods to get user input from console and writing to console lives in the Console namespace. below you already have an example how to write to console.
        // 
        // 3. stop console from closing straightaway when it finished running the code.  Hint: How did you wait for user input?

        // Bonus
        // 1. Make it multiple use without closing. Hint: Put it in a while loop
        // 2. Return a friendly message if input is invalid instead of crashing.
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the simple calculator!");


            // Get user input from console.  

            // Pass input to calculate method and assign result to a new variable

            // output result from Calculate to console

        }
    }

    public static class Calculator
    {
        public static long Calculate(string inputString)
        {
            
            return 0;
        }
    }
}
