using System; 

namespace PizzaBox.Domain
{
  public class Menu
  {
    string user, loc, f, l, handlerString, userString;
    int handlerInt;
    public Menu()
    {
      Start();
    }
    public void Start()
    {
      Console.WriteLine("\n\nHi! I'm Casca and I will be assisting you with your order today\n");
      do
      {
        do
        {
        System.Console.WriteLine("Are you an existing user [y]es or [n]o\n");
        Account.Instance();
        incoming();
        
        if (handlerString=="y")
        {
          System.Console.WriteLine("Please input your username");
          incoming();
          handlerInt=Account.CustExist(handlerString);
          if (handlerInt==0)
          {
            Console.WriteLine("That is not an existing user. Please try again: ");}
          else
          {user=handlerString;}        
        }
          else if(handlerString=="n")
          {
            int i;
            System.Console.WriteLine("Please input firstname");
            incoming();
            f=handlerString;
            System.Console.WriteLine("Please input lastname");
            incoming();
            l=handlerString;
            System.Console.WriteLine("Please input custom username");
            incoming();
            i=Account.CustExist(handlerString);
            if(i==0)
            {
              Account.newUser(f,l,handlerString);
              //i=Account.CustExist(handlerString);
              user=handlerString;
            }
          }
        }while(handlerInt==0);
        Location loc = new Location();
        do
        {
          Console.WriteLine("Great,"+ user +", how would you like to proceed?\n [h]View order history\n [o]start new order\n[d] exit");
          incoming();
          if (handlerString == "h")
          {
            //display user history
          }
        }
      while(handlerString!="o" && handlerString != "d");

      if (handlerString =="o")
      {
        Order o = new Order(loc.returnLoc(), userString);
      }
      if (handlerString =="d")
      {
        System.Console.WriteLine("Thanks for chooseing PizzaBox! Your order will be made soon!");
      }
      
      }while(true);//---------------------------------------------
    }
    public void incoming()
    {
      handlerString=System.Console.ReadLine();
      handlerString=handlerString.ToLower();
    }  
  }  
}
