using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouTubeVideoName;
namespace UnitTestProjectApplication
{
  [TestClass]
  public class UnitTestApplication
  {
    [TestMethod]
    public void TestGenerateRandomNumber()
    {
      int result = FormMain.GenerateRandomNumber(1, 4);
      for (int i = 0; i < 10; i++)
      {
        result = FormMain.GenerateRandomNumber(1, 4);
        Assert.IsTrue(result >= 1 && result <= 4);
      }

      result = FormMain.GenerateRandomNumber(1, 4);
      Assert.IsFalse(result >= 4);
    }

    [TestMethod]
    public void TestGenerateRandomNumberEqualTo1()
    {
      int result = FormMain.GenerateRandomNumber(1, 4);
      bool findA1 = false;

      for (int i = 0; i < 100; i++)
      {
        result = FormMain.GenerateRandomNumber(1, 4);
        if (result == 1)
        {
          findA1 = true;
        }
      }

      Assert.IsTrue(findA1);
    }

    [TestMethod]
    public void TestGenerateRandomNumberEqualTo2()
    {
      int result = FormMain.GenerateRandomNumber(1, 4);
      bool findA2 = false;
      for (int i = 0; i < 10; i++)
      {
        result = FormMain.GenerateRandomNumber(1, 4);
        if (result == 2)
        {
          findA2 = true;
        }
      }

      Assert.IsTrue(findA2);
    }

    [TestMethod]
    public void TestGenerateRandomNumberEqualTo3()
    {
      int result = FormMain.GenerateRandomNumber(1, 4);
      bool findA3 = false;
      for (int i = 0; i < 10; i++)
      {
        result = FormMain.GenerateRandomNumber(1, 4);
        if (result == 3)
        {
          findA3 = true;
        }
      }

      Assert.IsTrue(findA3);
    }

    [TestMethod]
    public void TestGenerateRandomNumberEqualTo4()
    {
      int result = FormMain.GenerateRandomNumber(1, 4);
      bool findA4 = false;
      for (int i = 0; i < 100; i++)
      {
        result = FormMain.GenerateRandomNumber(1, 4);
        if (result == 4)
        {
          findA4 = true;
        }
      }

      Assert.IsTrue(findA4);
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