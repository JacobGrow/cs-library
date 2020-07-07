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
      Running = true;
      while (Running){
        Console.WriteLine("Would you like to check out a book? (y/n)");
        Console.WriteLine()
      }

    }
  }


}