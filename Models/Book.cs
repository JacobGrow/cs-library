using System;
using System.Collections.Generic;

namespace library.Models
{
  public class Book
  {
    public string Title { get; set;}
    public string Author { get; set; }
    public int InStock { get; set; }
    public bool Available { get { return InStock > 0; } }

    public Book(string title, string author, int inStock)
    {
      Title = title;
      Author = author;
      InStock = inStock;
    }
  }
}