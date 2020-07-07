using System;
using System.Collections.Generic;

namespace library.Models
{
  public class Library{
    public string Name { get; set; }
    public string Location { get; set; }

    public List<Book> Books { get; set; } = new List<Book>();
    public Library(string location, string name)
    {
      Location = location;
      Name = name;

      Books.Add(new Book("The Count of Monte Cristo", "Alexandre Dumas"));
      Books.Add(new Book("Basic Economics", "Thomas Sowell"));
      Books.Add(new Book("The Fellowship of the Ring", "J.R.R. Tolkien"));
    }

    public void ViewBooks(bool available)
    {
      Console.WriteLine("Book Stock");
      for (int i = 0; i < Books.Count; i++)
      {
        Console.WriteLine($"{i + 1}");
      }
    }
  }
}