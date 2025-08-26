// using System.Runtime.InteropServices;

// System.Console.WriteLine("Enter a number");
// string input = Console.ReadLine();
// try
// {
//   int number = ParseStringToInt(input);
//   System.Console.WriteLine($"String successfully parsed, the result is {input}");
// }
// catch(Exception ex)
// {
//   System.Console.WriteLine("An exception was thrown. Exception message: " + ex.Message);
// }
// finally
// {
//   System.Console.WriteLine("Finally block is being executed.");
// }
// Console.ReadKey();

// int ParseStringToInt(string input)

//   {
//     return int.Parse(input);
//   }


Console.ReadKey();

public static class ExceptionsDivisionExercise
    {
        public static int DivideNumbers(int a, int b)
        {
    try
    {
      return a / b;
    }
    catch
    {
 
        System.Console.WriteLine("Division by zero.");
        return 0;
      }
    
    finally
    {
      System.Console.WriteLine("The DivideNumbers method ends.");
    }

        }
    }