using System;
using System.Collections.Generic;

namespace library.Models
{
  public class Bluray : Media
  {
    public string Director{ get; set; }
    public int Length { get; set; }
    public string Genre { get; set; }
   
  public Bluray( string director, int length, string genre, string title, int year, string description, int inStock) : base( year, title, inStock, description)
  {
    Director = director;
    Length = length;
    Genre = genre;
  }
  }
}