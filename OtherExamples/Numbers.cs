namespace Excemptions.Numbers
{
  public class OtherStuff
  {
    void Example()
    {
      System.Console.WriteLine("Enter a number");
      string input = Console.ReadLine();
      try
      {
        int number = int.Parse(input);
        var result = 10 / number;
        System.Console.WriteLine($"10 / {number} is {result}");
      }
      catch (DivideByZeroException ex)
      {
        int.Parse("not an int");
        System.Console.WriteLine($"Division by zero is an invalid operation.\r\nException message: {ex.Message}");
      }
      catch (FormatException ex)
      {
        System.Console.WriteLine($"Wrong format. Input string is not parsable to int. \r\nException message: {ex.Message}");
      }

      Console.ReadKey();
    }
  }
}