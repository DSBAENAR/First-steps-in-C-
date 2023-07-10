using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night.\nYou're sitting in your room and hear \na noise coming from down the hall. Do \nyou go investigate? ");
      Console.Write("Type YES or NO\n");
      string noiseChoise = Console.ReadLine();
      noiseChoise = noiseChoise.ToUpper();
      if (noiseChoise == "NO") {
        Console.WriteLine("Not much of an adventure if we don't \nleave our room! \nTHE END.");
      }

      else if (noiseChoise == "YES") {
        Console.WriteLine("You walk into the hallway and see \na light coming from under a door down \nthe hall.\nYou walk towards it. Do you open it or \nknock?");
        }
      Console.Write("Type OPEN or KNOCK\n");
      string doorChoice = Console.ReadLine();
      doorChoice = doorChoice.ToUpper();

     if (doorChoice == "OPEN") {
        Console.WriteLine("The door is locked! See if one of your \nthree keys will open it.");
     }
     else {
        Console.WriteLine("You answered incorrectly. The door \ndoesn't open.\nTHE END.");
     }
     Console.WriteLine("Enter a number (1-3): ");
     string keyChoice = Console.ReadLine();
     keyChoice = keyChoice.ToUpper();
     switch (keyChoice) {
       case "1":
        Console.WriteLine("You choose the first key. Lucky \nchoice!\nThe door opens and NOTHING is there. \nStrange...\nTHE END.");
        break;
       case "2":
        Console.WriteLine("You choose the second key. The door \ndoesn't open.\nTHE END.");
        break;
       case "3":
        Console.WriteLine("You choose the third key. The door \ndoesn't open.\nTHE END.");
        break;
     }
        }
      } 
    }



