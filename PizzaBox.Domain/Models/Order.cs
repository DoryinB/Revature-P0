using System.Collections.Generic;
using System;

namespace PizzaBox.Domain
{
  public class Order
  {
    private List<Pizza> pizzas = new List<Pizza> {};
    private decimal totalCost;
    private string location;
    private string userName;
    private string choice;
    //char holder;
    public Order(string loc, string un)
    {
      totalCost = 0.00m;
      location = loc;
      userName = un;
      do{
        Console.WriteLine("Hello "+un+", let's begin your order.\n Would you like to [n]add a pizza to your order, [o]display order and cost total, [d] complete order");
        incoming();
        if (choice=="n")
        {
          Pizza p = new Pizza();
          pizzas.Add(p);
          
        }
        else if (choice=="o")
        {
          displayOrder();
        }
        else if (choice !="d")
        {
          Console.WriteLine("That is not a valid option");
        }
      }while(choice != "d");
      Console.WriteLine("\nYour order is now complete!"); 
    }

    public void incoming()  
    {
    choice = Console.ReadLine();
    choice = choice.ToLower();
    }

    public decimal returnTotalCost()
    {
      return totalCost;
    }

    public void displayOrder()
    {
      foreach (var p in pizzas)
      {
        p.displayPizza();
      }
    }
    public void addPizza()
    {
      Pizza p = new Pizza();
      pizzas.Add(p);
      totalCost=totalCost+p.returnCost();
      displayOrder();
    }
  }
}