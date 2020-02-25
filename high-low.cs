using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Would you like to play the higher or lower game? (yes/no)");
    string userInput = Console.ReadLine();

    if ( userInput == "yes" )
    {
      Guess();
    }
  }  

  public static void Guess()
  {
    int max = 100;
    int guess = max / 2;
    Console.WriteLine("Is your number higher of lower than " + guess + "? higher/lower/correct");
    string userInput = Console.ReadLine();

    if ( userInput == "lower" ) 
    {
      guess = guess / 2;
      Console.WriteLine("Is your number higher of lower than " + guess + "? higher/lower/correct");
      
    }
    else if ( userInput == "higher" )
    {
      guess = (max + guess) / 2;
      Console.WriteLine("Is your number higher of lower than " + guess + "? higher/lower/correct");
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


