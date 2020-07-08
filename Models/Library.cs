using System;
using System.Collections.Generic;

namespace library.Models
{
  public class Library{
    public string Name { get; set; }
    public string Location { get; set; }

    public List<Book> Books { get; set; } = new List<Book>();
    public List<Magazine> Magazines { get; set; } = new List<Magazine>();

    public List<Bluray> Blurays { get; set; } = new List<Bluray>();
    public Library(string location, string name)
    {
      Location = location;
      Name = name;

      Books.Add(new Book("Adventure", 1500, "The Count of Monte Cristo", "Alexandre Dumas", "Totally awesome about guy gets revenge.",5));
      Books.Add(new Book("Nonfiction", 450,"Basic Economics", "Thomas Sowell", "Thomas Sowell is one smart feller", 1));
      Books.Add(new Book("Fantasy", 379, "The Fellowship of the Ring", "J.R.R. Tolkien", "One ring to bring them all, and in the darkness bind them", 8));
      Books.Add(new Book("Sci-Fi", 460, "20,000 Leagues Under The Sea", "Jules Verne", "Awesome story about giant squid", 3));
      Books.Add(new Book("Sci-Fi", 280, "War of the Worlds", "H.G. Wells", "Scary aliens invade and we totally give em a disease.", 2));
      Books.Add(new Book("Horror", 78, "The Call of Cthulu", "H.P. Lovecraft", "A cult worships an old fish dude and he comes out of the ocean super vision", 1));
    
      Magazines.Add(new Magazine("Men's Health", "July 2020", "Health and Fitness", "Publisher Inc.", "Read if you wanna get ripped", 1));
      Magazines.Add(new Magazine("Computers/Tech", "June 2020", "National Programming", "Mag Publishers Inc.", "Read if you wanna look smart.", 1));

      Blurays.Add(new Bluray("Steven Spielberg", 120, "Horror", "Jaws", 1980, "Shark totally eats a whole town", 3));
      Blurays.Add(new Bluray("Christopher Nolan", 260, "Sci-Fi", "Interstellar", 2014, "Sick space stuff", 2));
    }

    public void ViewBooks()
    {
      Console.WriteLine("Books Currently In Stock : \n");
      for (int i = 0; i < Books.Count; i++)
      {
        Book book = Books[i];
        if (book.Available)
        {
          Console.WriteLine($"{i+1}. {book.Title} ");
          Console.WriteLine("------------------------------------------------------------");
        }
      }
    }
    public void ViewBooks(bool available)
    {
      Console.WriteLine("Book Stock");
      ConsoleColor forecolor = Console.ForegroundColor;
      for (int i = 0; i < Books.Count; i++)
      {
        Book book = Books[i];
       if (book.Available == available)
       {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine($"{i + 1}. {book.Title} by {book.Author} x {book.InStock}");
       }
       else
       {
         Console.ForegroundColor = forecolor;
         Console.WriteLine($"{i + 1}. {book.Title} by {book.Author} x {book.InStock}");
       }
      }
      Console.ForegroundColor = forecolor;
    }

    public void ViewMagazines()
    {
      Console.WriteLine("Available Magazines:");
      for (int i = 0; i < Magazines.Count; i++)
      {
        Magazine magazine = Magazines[i];
        Console.WriteLine($"{i + 1}. {magazine.Title} {magazine.Edition}");
      }
    }

    internal Book checkBookAvailability(string selection)
    {
      int bookIndex;
      bool valid = Int32.TryParse(selection, out bookIndex);
      if (!valid || bookIndex < 1 || bookIndex > Books.Count)
      {
        return null;
      }
      return Books[bookIndex - 1];
    }
  }
}