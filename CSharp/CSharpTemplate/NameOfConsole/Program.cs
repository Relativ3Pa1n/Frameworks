using System;
using NameOfClassLibrary;

namespace NameOfConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      NameOfPerson p = new NameOfPerson
      {
        FirstName = "Fauw",
        LastName = "Baur"
      };
      System.Console.WriteLine($"{ p.FirstName } { p.LastName } is the person's name.");
    }
  }
}

