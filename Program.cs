System.Console.WriteLine("Enter a number");
string input = Console.ReadLine();
try
{
  int number = ParseStringToInt(input);
  var result = 10 / number;
  System.Console.WriteLine($"10 / {number} is {result}");
}
catch (FormatException ex)
{
  System.Console.WriteLine("Wrong format. Input string is not parsable to int. Exception message: " + ex.Message);
}
catch (DivideByZeroException x)
{
  System.Console.WriteLine($"Division by zero is an invalid operation jackass🤡. Exception message: {x.Message}");
}
catch(Exception x)
{
  System.Console.WriteLine($"Yo homie, an unexpected error occured, idk what the hell you did dog. Error message: {x.Message}");
}
finally
{
  System.Console.WriteLine("Finally block is being executed.");
}
Console.ReadKey();

int ParseStringToInt(string input)

{
  return int.Parse(input);
} 
