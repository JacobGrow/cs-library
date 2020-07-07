using System;
using System.Collections.Generic;

namespace library.Models
{
  public class Library{
    public string Name { get; set; }
    public string Location { get; set; }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
    }
  }
}