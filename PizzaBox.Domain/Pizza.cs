using System.Collections.Generic;

namespace PizzaBox.Domain
{
  public class Pizza
  {
    private decimal cost;
    private string choice;
    private List<string> pizTopList = new List<string>{};
    private int toppingsMax;
    Crust crust;
    Size size;

    public Pizza()
    {
      pizTopList.Add("peperoni");
      pizTopList.Add("bacon");
      cost = 1.00m;
      toppingsMax = 2;
      crust = new Crust();
      size = new Size();
      cost = cost + crust.returnCrustCost()+size.returnSizeCost();
      menu();
      System.Console.WriteLine("\n\n");
      System.Console.WriteLine("Your "+size.returnSize()+" "+crust.returnCrust()+" Pizzawith ");
      foreach (string s in pizTopList)
      {
        System.Console.Write(s+", ");
      }
      System.Console.Write(" will be totaled at "+ cost);
           
    }

    public void menu()
    {
      do
      {
      System.Console.WriteLine("\n\nLets add some toppings to your "+size.returnSize()+" "+crust.returnCrust()+" Pizza!\nYou currently have: ");
      foreach (string s in pizTopList)
        {
          System.Console.Write(s+", ");
        }
      System.Console.WriteLine("\nYour current pizza will cost " + cost + " Would you like to: [a]dd a topping, [r]emove a topping, [f]inish current pizza.");
      choice = System.Console.ReadLine();
      choice = choice.ToLower();
      Thing();
      }
      while (choice != "f");
    }

    public int Thing()
    {
      if(choice == "r")
      {
        System.Console.WriteLine("Which topping would you like to remove?");
        string r = System.Console.ReadLine();
        if(pizTopExist(r))
        {
        pizTopList.Remove(r);
        cost = cost-.50m;
        return 1;
        }
        
        System.Console.WriteLine("You do not currently have that topping.");
        return 1;        
      }
      else if(choice == "a")
      {
        if (toppingsMax<5)
        {
        System.Console.WriteLine("Which topping would you like to add?");
        string a = System.Console.ReadLine();
        if(Topping.toppingExist(a))
          {
          Add(a);
          cost = cost + .50m;
          return 1;
          }
        }
        else
        System.Console.WriteLine("I'm sorry you have hit the toppings limit. You must remove a topping to add one.");
        return 1;
      }
      else if(choice!="f") 
      {
        System.Console.WriteLine("That is not a valid option");
      return 1;
      }
      else return 1;
    }

    public void Add(string t)
    {
      if (Topping.toppingExist(t))
      {
        pizTopList.Add(t);
        toppingsMax++;
      }
      else
      {
        System.Console.WriteLine("that is not an available topping at your desired location");
      }
    }

    public bool pizTopExist(string t)
    {
      foreach (string s in pizTopList)
      {
        if (s == t)
        {return true;}
      } 
      return false;
    }

    public void displayPizza()
    {
      System.Console.WriteLine(size.returnSize()+" "+crust.returnCrust()+" Pizza with ");
      foreach (string s in pizTopList)
        {
          System.Console.Write(s+", ");
        }
    }

    public decimal returnCost()
    {
      return cost;
    } 

  }
}