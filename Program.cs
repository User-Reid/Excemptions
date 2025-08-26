try
{
  var result = GetFirstElement(new int[0]);
}
catch
{
  
}

Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
  foreach (var number in numbers)
  {
    return number;
  }
  throw new Exception("The collection cannot be empty. jackass🤡");
}