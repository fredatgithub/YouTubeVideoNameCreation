using System;
using YouTubeVideoName;
namespace ApplicationUsage
{
  class Program
  {
    static void Main()
    {
      Action<string> Display = s => Console.WriteLine(s);
      Action<string> DisplayWithoutCR = s => Console.Write(s);
       for (int i = 0; i < 900; i++)
      {
        int result = FormMain.GenerateRandomNumber(1, 9);
        DisplayWithoutCR(result + " ");
      }
      Console.ReadKey();
    }
  }
}