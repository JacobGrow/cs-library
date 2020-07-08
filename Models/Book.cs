using System;
using System.Collections.Generic;

namespace library.Models
{
  public class Book : Publication
  {
    public string Genre { get; set; }
    public int PageCount { get; set; }
   
  public Book( string genre, int pagecount, string title, string author, string description, int inStock) : base(title, author, description, inStock)
  {
    Genre = genre;
    PageCount = pagecount;
  }
  }
}