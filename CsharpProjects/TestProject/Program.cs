/*
This C# console application is designed to:
- Use the Random class to generate an integer between 1 and 5.
- Use a nullable string? to collect input as a string from users and store it in another string.
- Use the TryParse method to convert the string to a number.
- Use a bool type to return true or not if it is a number.
- Use a nested 'if-elseif-else' construct to ensure the input is a number.
- Use an outer do-while loop to ensure the condition is met.

- Output looks like this:

Guess a number between 1 and 4
z
Sorry you entered an invalid number

Guess a number between 1 and 4
7
Too high

Guess a number between 1 and 4
0
Too low

Guess a number between 1 and 4
2
Your guess 2, does not match. Please try again

Guess a number between 1 and 4
3

Congratulations! Your guess 3, is correct. // 3 might not be a match other times
*/

string? readResult;
string valueEntered = "";
bool validNumber = false;

Random guess = new Random();
int guessedNumber = 0;
int correctNumber = guess.Next(1, 5);

do
{
 
 Console.WriteLine("Guess a number between 1 and 4");

 readResult = Console.ReadLine();

 if (readResult != null)
 {

  valueEntered = readResult;

 }

 validNumber = int.TryParse(valueEntered, out guessedNumber);

 /*
 This nested 'if-elseif-else' construct ensures a number is entered
 */
 if (validNumber == true)
 {

  if (guessedNumber != correctNumber)
  {

   validNumber = false;

   if (guessedNumber < 1)
   {

    Console.WriteLine("Too low");

   }

   else if (guessedNumber > 4)
   {

    Console.WriteLine("Too high");

   }

   else
   {

    Console.WriteLine($"Your guess {valueEntered}, does not match. Please try again");

   }

  }

 }

 else
 {

  Console.WriteLine("Sorry you entered an invalid number");

 }

Console.WriteLine();

} while (guessedNumber != correctNumber);

Console.WriteLine($"Congratulations! Your guess {guessedNumber}, is correct.");
Console.WriteLine();