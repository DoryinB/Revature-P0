using System.Collections.Generic;
using System;


namespace PizzaBox.Domain
{
  public class Crust
  {
    private static List<string> crust = new List<string> {"Thin", "Thick", "Stuffed"};
    private decimal cost;
    private string choice;
    char holder;
    public Crust()
    {cost = 0.00m;
    choice = menu();
    }

    public string menu()
    {
      do{
      System.Console.WriteLine("Please insert the crust would you like for your pizza?: ");
      char counter='a';
      foreach (string c in crust)
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
      foreach (string c in crust)
      {
        if (counter == ch)
        {return c;}
        else
        {counter++;
        cost = cost+.75m;}
      } 
      return "invalid input";
    }

    public decimal returnCrustCost()
    {
      return cost;
    }
    public string returnCrust()
    {
      return choice;
    }
    public static void displayCrusts()
    {
      foreach (var c in crust)
      {
        System.Console.Write(c+", ");
      }
    }
  }
}