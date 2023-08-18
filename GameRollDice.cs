using System;

Random dice = new Random();
int roll1 = dice.Next(1,6);
int roll2 = dice.Next(1,6);
int roll3 = dice.Next(1,6);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

int extraPoints;


if ((roll1 == roll2) && (roll1 == roll3)) {
    extraPoints = 6;
    Console.WriteLine($" You have extra points: {extraPoints} points more");
    total += extraPoints;
}

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)) {
    extraPoints = 2;
    Console.WriteLine($" You have extra points: {extraPoints} points more");
    total += extraPoints;

}

if (total > 14) {
    Console.WriteLine($" Your score was: {total}. Excellent you won");
}

else {
    Console.WriteLine($" Your score was: {total}. Sorry, you lost. Try again!");
}

// This exercise was proposed by Microsoft Learn 
