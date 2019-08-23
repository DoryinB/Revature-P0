using System.Collections.Generic;

namespace PizzaBox.Domain
{
  public class Topping
  {
    private static List<string> toppingsList = new List<string>{"apples","beef","chicken","bacon","peperoni","mushroom","onions" };
    
    public static bool toppingExist(string topping)    
    {
      foreach (string t in toppingsList)
      {
        if(topping==t)
        {return true;}
      }
      return false;
    }

    public static void displayToppings()
    {
      foreach (var c in toppingsList)
      {
        System.Console.Write(c+", ");
      }
    }

  }
}
