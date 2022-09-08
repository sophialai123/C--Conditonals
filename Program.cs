// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;

      bool yourNeeds = beach && city;

      bool friendNeeds = beach || hiking;

     bool tripDecision = yourNeeds && friendNeeds;
     Console.WriteLine(tripDecision);


    //If...Else... Statements
      int people = 12;
      string weather = "bad";
      
      if( people <= 10 && weather =="nice"){
        Console.WriteLine("SaladMart");
      }else{
          Console.WriteLine("Soup N Sandwich");

      }

      //To get user input, use the command Console.ReadLine()
      // and save the response to a string variable:
      Console.WriteLine("what is your genre?");
      string genre = Console.ReadLine();
      
      //Switch Statements
      switch(genre){
        case "Drama":
             Console.WriteLine("Citizen Kane");
             break;
         case "Comedy":
             Console.WriteLine("Duck Soup");
              break;
         case "Adventure":
             Console.WriteLine("King Kong");
              break;
         case "Horror":
             Console.WriteLine("Psycho");
              break;
         case "Science Fiction":
             Console.WriteLine("2001: A Space Odyssey");
              break;
        default:
             Console.WriteLine("No movie found");
             break;
      };


      //Ternary Operators
      
        int pepperLength = 4;
      string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
      Console.WriteLine(message);


    }
  }
}
