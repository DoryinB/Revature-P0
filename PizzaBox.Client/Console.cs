using System;
using PizzaBox.Domain;

namespace PizzaBox.Client
{
  class Program
  {
    private const string path = @"c:/Revature/PizzaBox/accounts.xml";
    string handler;
        
    public static void Main(string[] args)
    {
      Console.WriteLine("Start!\n");
      var p = new Program();
      do{
      Console.WriteLine("User [u] or Store [s]?");
      p.handler = Console.ReadLine();
      }
      while(p.handler!="u" && p.handler!="c");
      if (p.handler=="u")
      {Menu menu = new Menu();}
      
    }
    public int trueFalse(string s)
    {
      s = Console.ReadLine();
      s = s.ToLower();
      if (s=="y")
      {return 1;}
      else if (s=="n")
      {return 2;}
      else 
      {Console.WriteLine("You hav input an invalid option. Please try again.");
      return 3;}
    }
  }
}
