using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLenght = 8;
      int score = 0;
      Console.WriteLine("The password must have the next requirements:\n At least 8 characters long\n Has lowercase letters\n Has uppercase letters\n Has numerical digits\n Has symbols, like #, ?, !");
      Console.WriteLine("Please input your password");

      string userPassword = Console.ReadLine();
      int passwordLenght = userPassword.Length;

      if (passwordLenght > 7) {
        score++;
      }
      if (Tools.Contains(userPassword,"ABCDEFGHIJKLMNOPQRSTUVWXYZ")) {
        score++;
      }

      
      if (Tools.Contains(userPassword,"abcdefghijklmnopqrstuvwxyz")) {
        score++;
      }
      
      if (Tools.Contains(userPassword,"0123456789")) {
        score++;
      }
      
      if (Tools.Contains(userPassword,"!\"#$")) {
        score++;
      }
      if (Tools.Contains(userPassword,"password")) {
        score = 0;
      }
      string scoreString = $"{score}" ;
      switch (scoreString) {
        case "5" :
          Console.WriteLine("Your password is extremely strong");
          break;
        case "4" :
          Console.WriteLine("Your password is extremely strong");
          break;
        case "3" :
          Console.WriteLine("Your password is strong");
          break;
        case "2" :
          Console.WriteLine("Your password is medium");
          break;
        case "1" :
          Console.WriteLine("Your password is weak");
          break;
        default:
          Console.WriteLine("Your password doesn’t meet any of the standards");
          break;
      }
    }
  }
}
/*

If the password contains uppercase letters, add a point.

The course provided a custom tool that checks for certain characters in a string, called Tools.Contains().

Call it like this:

Tools.Contains(target, list);
target would be the password and list would be a string of characters you’d like to check for. If it finds a match, it returns true. If it does not, it returns false.

For example:
if the user inputted "password" as password then
Tools.Contains("password","abc"); true
Tools.Contains("password","123"); false

