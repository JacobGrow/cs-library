using System;
using library.Models;

namespace library
{
  public class App
  {
    public Library Library {get; set; }
    public bool Running { get; private set; }
    public void Run()
    {
      Console.Clear();
      Library = new Library("Boise, ID", "Jake's Books");
      Console.WriteLine($"\nWelcome to {Library.Name} in {Library.Location}");
      Console.WriteLine("----------------------------------------------");
      Running = true;
      while (Running)
      {
        Console.WriteLine("Would you like to check out a book? (y/n)");
        Console.WriteLine("----------------------------------------------");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
          case "y":
            CheckOut();
          break;
          case "n":
          Console.Clear();
            Console.WriteLine("Then what are you botherin me for?");
            Running = false;
            break;
        }

      }
      void CheckOut()
      {
        Console.Clear();
        Library.ViewBooks();
        Console.WriteLine("These are the only books we have so either pick one or get outta here.");
         Console.WriteLine("------------------------------------------------------------");
         string selection = Console.ReadLine();
         Book selectedBook = Library.checkBookAvailability(selection);
         if (selectedBook == null)
         {
           Console.WriteLine("Invalid Selection");
           return;
         }
         
      }

    }
  }


}