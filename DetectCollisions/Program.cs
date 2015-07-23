/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using YouTubeVideoName;

namespace DetectCollisions
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      Action<string> displayWithoutCr = Console.Write;
      ulong counter = 0;
      bool collisionfound = false;
      string source = CreateName();
      for (int i = 0; i < 20; i++)
      {
        string collision = CreateName();
        display(source + " " + counter +  " = " + collision);
        if (collision == source)
        {
          collisionfound = true;
        }

        if (collisionfound)
        {
          break;
        }

        counter++;
      }

      while (!collisionfound)
      {
        string collision = CreateName();
        display(source + " " + counter + " = " + collision);
        if (collision == source)
        {
          collisionfound = true;
        }

        if (collisionfound)
        {
          break;
        }

        counter++;
      }

      display("");
      display("Press a key to exit:");
      Console.ReadKey();
    }

    public static string CreateName()
    {
      List<char> lettersUpper = new List<char>();
      List<char> lettersLower = new List<char>();
      List<int> chiffres = new List<int>();
      List<char> specialCharacters = new List<char>();
      for (int i = 0; i < 10; i++)
      {
        chiffres.Add(i);
      }

      for (char i = 'a'; i <= 'z'; i++)
      {
        lettersLower.Add(i);
      }

      for (char i = 'A'; i <= 'Z'; i++)
      {
        lettersUpper.Add(i);
      }

      specialCharacters.Add('_');
      specialCharacters.Add('-');
      const byte videoNameLength = 11;
      int count = 0;
      string name = string.Empty;
      while (count < videoNameLength)
      {
        // choosing letters or number
        int choiceLetters = GenerateRandomNumber(1, 4);
        switch (choiceLetters)
        {
          case 1:
            //abcdefghijklmnopqrstuvwxyz
            //12345678901234567890123456
            name += lettersLower[GenerateRandomNumber(0, 25)];
            break;
          case 2:
            name += lettersUpper[GenerateRandomNumber(0, 25)];
            break;
          case 3:
            name += chiffres[GenerateRandomNumber(0, 9)];
            break;
          case 4:
            name += specialCharacters[GenerateRandomNumber(0, 1)];
            break;
        }

        count++;
      }

      return name;
    }

    public static int GenerateRandomNumber(int min, int max)
    {
      if (max >= 255)
      {
        return 0;
      }

      int result;
      RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
      byte[] randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result < min || result > max);

      return result;
    }
  }
}