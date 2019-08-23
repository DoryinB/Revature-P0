using System.Collections.Generic;
using System;

namespace PizzaBox.Domain
{
  public class Location
  {
    private List<string> locList = new List<string> {"loc123", "loc234", "loc345", "loc456"};
    private string choice;
    char holder;
    public Location()
    {choice = menu();
    }

    public string menu()
    {
      int count=0;
      do{
      System.Console.WriteLine("Please insert the location would you like for your order?: ");
      char counter='a';
      foreach (string l in locList)
      {
        Console.Write("[" +counter+ "] " + l);
        counter++;
      }
      Console.WriteLine("\n\n");
      choice=System.Console.ReadLine();
      choice=choice.ToLower();
      holder = counter;
      }while(choice[count]>holder);
      return choose(choice[0]);
    }

    public string choose(char ch)
    {
      char counter='a';
      foreach (string c in locList)
      {
        if (counter == ch)
        {return c;}
        else
        {counter++;}
      } 
      return "invalid input";
    }

    public string returnLoc()
    {
      return choice;
    }
  }
}