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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouTubeVideoName;
namespace UnitTestProjectApplication
{
  [TestClass]
  public class UnitTestApplication
  {
    [TestMethod]
    public void TestGenerateRandomNumber_within_range()
    {
      for (int i = 0; i < 10; i++)
      {
        int result = FormMain.GenerateRandomNumber(1, 4);
        Assert.IsTrue(result >= 1 && result <= 4);
      }
    }

    [TestMethod]
    public void TestGenerateRandomNumber_within_several_range()
    {
      for (int i = 10; i < 240; i++)
      {
        int result = FormMain.GenerateRandomNumber(i, i + 10);
        Assert.IsTrue(result >= i && result <= i + 10);
      }
    }

    [TestMethod]
    public void TestGenerateRandomNumber_not_outside_range()
    {
      for (int i = 0; i < 100; i++)
      {
        int result = FormMain.GenerateRandomNumber(1, 4);
        Assert.IsFalse(result > 4);
      }
    }

    [TestMethod]
    public void TestGenerateRandomNumberEqualTo1()
    {
      bool findOne = false;
      for (int i = 0; i < 100; i++)
      {
        int result = FormMain.GenerateRandomNumber(1, 4);
        if (result == 1)
        {
          findOne = true;
        }
      }

      Assert.IsTrue(findOne);
    }

    [TestMethod]
    public void TestGenerateRandomNumberEqualTo2()
    {
      bool findTwo = false;
      for (int i = 0; i < 100; i++)
      {
        int result = FormMain.GenerateRandomNumber(1, 4);
        if (result == 2)
        {
          findTwo = true;
        }
      }

      Assert.IsTrue(findTwo);
    }

    [TestMethod]
    public void TestGenerateRandomNumberEqualTo3()
    {
      bool findThree = false;
      for (int i = 0; i < 100; i++)
      {
        int result = FormMain.GenerateRandomNumber(1, 4);
        if (result == 3)
        {
          findThree = true;
        }
      }

      Assert.IsTrue(findThree);
    }

    [TestMethod]
    public void TestGenerateRandomNumberEqualTo4()
    {
      bool findFour = false;
      for (int i = 0; i < 100; i++)
      {
        int result = FormMain.GenerateRandomNumber(1, 5);
        if (result == 4)
        {
          findFour = true;
        }
      }

      Assert.IsTrue(findFour);
    }

    [TestMethod]
    public void TestCreateNameLength()
    {
      string result = FormMain.CreateName();
      Assert.IsTrue(result.Length == 11);
    }

    [TestMethod]
    public void TestCreateNameHasUpperCaseLetterZ()
    {
      string result = FormMain.CreateName();
      bool findOneLetterZ = false;
      Assert.IsTrue(result.Length == 11);
      for (int i = 1; i < 50; i++)
      {
        result = FormMain.CreateName();
        if (result.Contains("Z"))
        {
          findOneLetterZ = true;
          break;
        }
      }

      Assert.IsTrue(findOneLetterZ);
    }

    [TestMethod]
    public void TestCreateNameHasSpecialCharacters()
    {
      string result = FormMain.CreateName();
      bool findSpecialCharacter = false;
      for (int i = 1; i < 5000; i++)
      {
        result = FormMain.CreateName();
        if (result.Contains("-") || result.Contains("_"))
        {
          findSpecialCharacter = true;
          break;
        }
      }

      Assert.IsTrue(findSpecialCharacter);
    }
  }
}