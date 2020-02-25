using System;

public class Program
{
  
  public static void Main()
  {
    Console.WriteLine("Would you like to play the higher or lower game? (yes/no)");
    string userInput = Console.ReadLine();

    if ( userInput == "yes" )
    {
      Guess(100, 50, 1);
    }
    else 
    {
    Console.WriteLine("k bye");
    }
  }  

  public static void Guess(int max, int guess, int min)
  {

    Console.WriteLine("Is your number higher of lower than " + guess + "? higher/lower/correct");
    string userInput = Console.ReadLine();

    if ( userInput == "lower" ) 
    {
      max = guess - 1 ;
      guess = (max + min) / 2; 
      Guess(max, guess, min);
    }
    else if ( userInput == "higher" )
    {
      min = guess + 1;
      guess = (min + max) / 2;
      Guess(max, guess, min);
    }
    else if ( userInput == "correct" )
    {
      Console.WriteLine("I have guessed your number! goodbye.");
    }
    else 
    {
      Console.WriteLine("bye");
    }
  } 
}


