using System;
using System.Collections.Generic;

namespace library.Models
{
  public class Magazine : Publication
  {
    public string Type { get; set; }
    public string Edition { get; set; }
   
  public Magazine( string type, string edition, string title, string author, string description, int inStock) : base(title, author, description, inStock)

  {
    Type = type;
    Edition = edition;
  }
  }
}