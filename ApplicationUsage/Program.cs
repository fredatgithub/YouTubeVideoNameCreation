using System;
using YouTubeVideoName;
namespace ApplicationUsage
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      Action<string> displayWithoutCr = Console.Write;
      for (int i = 0; i < 900; i++)
      {
        int result = FormMain.GenerateRandomNumber(1, 9);
        displayWithoutCr(result + " ");
      }

      display("");
      display("Press a key to exit:");
      Console.ReadKey();
    }
  }
}