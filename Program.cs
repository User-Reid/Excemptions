using Excemptions.Numbers;

// var invallidPersonObject = new Person("", -100);

// var emptyCollection = new List<int>();
// var firstElement = GetFirstElement(emptyCollection);

// var numbers = new int[] { 1, 2, 3 };
// var fourth = numbers[3];
// var firstUsingLinq = emptyCollection.First();

// bool has7 = CheckIfContains(7, numbers);

// bool CheckIfContains(int value, int[] numbers)
// {
//   throw new NotImplementedException();
// }

try
{
  var result = IsFirstElementPositive(null);
}
catch (NullReferenceException ex)
{

}

Console.ReadKey();

throw new Exception()

void RecursiveMethod()
{
  System.Console.WriteLine("I'm going to call myself");
  RecursiveMethod();
}

int GetFirstElement(IEnumerable<int> numbers)
{
  foreach (var number in numbers)
  {
    return number;
  }
  throw new InvalidOperationException("The collection cant be empty shit for brains💩");
}

bool IsFirstElementPositive(IEnumerable<int> numbers)
{
  try
  {
    var firstElement = GetFirstElement(numbers);
    return firstElement > 0;
  }
  catch (InvalidOperationException ex)
  {
    System.Console.WriteLine("The collection is empty!");
    return true;
  }
  catch (NullReferenceException ex)
  {
    System.Console.WriteLine("Sorry homie! The application experience\r\n an unexpected error.");
    throw;
    // throw new ArgumentNullException("The collection is null.", ex);
  }
}

class Person
{
  public string Name { get; }
  public int YearOfBirth { get; }

  public Person(string name, int yearOfBirth)
  {
    if (name is null)
    {
      throw new ArgumentNullException("The name cannot be null jackass🤡.");
    }
    if (name == string.Empty)
    {
      throw new ArgumentException("The name cannot be empty jackass🤡.");
    }
    if (yearOfBirth < 1990 || yearOfBirth > DateTime.Now.Year)
    {
      throw new ArgumentOutOfRangeException("The year of birth must be\r\n between 1900 and the current year jackass🤡.");
    }

    Name = name;
    YearOfBirth = yearOfBirth;
  }
}