namespace Excemptions.Numbers
{
  public class Examples2
  {
    void Tacobell()
    {
      try
      {

        var dataFromWeb = SendHttpRequest("www.someAddress.com/get/someResource");
      }
      catch (HttpRequestException ex) when (ex.Message == "403")
      {
        System.Console.WriteLine("It was forbidden to access the resouce.");
        throw;
      }
      catch (HttpRequestException ex) when (ex.Message == "404")
      {
        System.Console.WriteLine("The resouce was not found.");
        throw;
      }
      catch (HttpRequestException ex) when (ex.Message.StartsWith("4"))
      {
        System.Console.WriteLine("There was some kind of client error.");
        throw;
      }
      catch (HttpRequestException ex) when (ex.Message == "500")
      {
        System.Console.WriteLine("There was an interal issue homie.");
      }

      Console.ReadKey();
    }
  }
}