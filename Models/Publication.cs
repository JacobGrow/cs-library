using System;
using System.Collections.Generic;

namespace library.Models
{
  public abstract class publication
  {
    public publication(string title, string author, string description)
    {
      Title = title;
      Author = author;
      Description = description;
    }
    public string Title {get; set;}
    public string Author {get; set;}
    public string Description { get; set;}
  }


}
