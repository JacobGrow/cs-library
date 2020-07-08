using System;
using System.Collections.Generic;
using library.Models;

namespace library.Models
{
  public abstract class Media // Base Class
  {
    public Media(int year, string title, int inStock, string description)
    {
      Year = year;
      Title = title;
      InStock = inStock;
      Description = description;
    }
    public int Year { get; set; }
    public string Title { get; set; }

    public int InStock { get; set; }

    public string Description { get; set; }
    public bool Available { get { return InStock > 0; } }
  }


}