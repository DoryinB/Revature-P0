using System.Collections.Generic;
using System;

namespace PizzaBox.Domain
{
  public class Size
  {
    private List<string> size = new List<string> {"Small", "Medium", "Large", "XstreamLarge"};
    private decimal cost = 4.00m;
    private string choice;
    char holder;
    public Size()
    {cost = 4.00m;
    choice = menu();
    }

    public string menu()
    {
      do{
      System.Console.WriteLine("Please insert the crust would you like for your pizza?: ");
      char counter='a';
      foreach (string c in size)
      {
        Console.Write("[" +counter+ "] " + c);
        counter++;
      }
      Console.WriteLine("\n\n");
      choice=System.Console.ReadLine();
      choice=choice.ToLower();
      holder = counter;
      }while(choice[0]>holder);
      return choose(choice[0]);
    }

    public string choose(char ch)
    {
      char counter='a';
      foreach (string c in size)
      {
        if (counter == ch)
        {return c;}
        else
        {counter++;
        cost = cost+1.50m;}
      } 
      return "invalid input";
    }

    public decimal returnSizeCost()
    {
      return cost;
    }
    public string returnSize()
    {
      return choice;
    }
  }
}