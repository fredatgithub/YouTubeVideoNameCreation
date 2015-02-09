using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace YouTubeVideoName
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void buttonCompute_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
      for (int i = 1; i < 59; i++)
      {
        listBox1.Items.Add(CreateName());
      }
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
      int choiceLetters = GenerateRandomNumber(1, 4);
      while (count < videoNameLength)
      {
        // choosing letters or number
        choiceLetters = GenerateRandomNumber(1, 4);
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