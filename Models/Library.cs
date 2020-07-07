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

      Books.Add(new Book("The Count of Monte Cristo", "Alexandre Dumas", 3));
      Books.Add(new Book("Basic Economics", "Thomas Sowell", 1));
      Books.Add(new Book("The Fellowship of the Ring", "J.R.R. Tolkien", 8));
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