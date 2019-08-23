using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Domain
{
  public class Account
  {
    private const string path = @"c:/Revature/PizzaBox/accounts.xml";
    private static List<Customer> _customers;
    
    public static List<Customer> Instance()
    {
      if (_customers == null)
      {
        Reading(); 
      }
      return _customers;
    }

    private Account() 
    {}

    public static void newUser(string f, string l, string u)
  {
    var c = new Customer
    {
      firstName=f,
      lastName=l,
      userName=u
    };
    Account.Instance().Add(c);
    //Save(c);
  }

  public static void Save(Customer p)
  {
    bool wait=false;
    while( !wait)
    {wait = SaveToDisk(Account.Instance());}
  }

   public static void Reading()
    {
      bool wait=false;
      while(!wait)
      {wait=(Read());};
    }

    public static bool Read()
    {
        var sr = new StreamReader(path);
        var xml = new XmlSerializer(typeof(List<Customer>));
        _customers = xml.Deserialize(sr) as List<Customer>;
        //returnCust();
        return true;
    }

    public static bool SaveToDisk(List<Customer> lp)
    {
      
      var fs = new FileStream(path, FileMode.OpenOrCreate);
      var xml = new XmlSerializer(typeof(List<Customer>));
      xml.Serialize(fs, lp);
      return false;
    }

    public static void returnCust()
    {
      foreach (Customer per in Account.Instance())
      {
        System.Console.WriteLine(per.firstName + " " + per.lastName);
      }
    }

    public static int CustExist(string custom)
    {
      int i = 1;
      foreach (Customer cust in Account.Instance())
      {
        if (custom.Equals(cust.userName))
        {return i;}
        i++;
      }
      return 0;
    }
  }
}
