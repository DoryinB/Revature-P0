namespace PizzaBox.Domain
{
  public class Customer
  {

    public string firstName { get; set; }
    public string lastName { get; set; }
    public string userName { get; set; }
    
    public string printCust()
    {
    return $"{firstName} {lastName}\n {userName}\n\n";
    }
  }
}

/*
  public int checkDuplicate(string custInput,List<string> names)
  {
    for(userId=0; userId<names.Count;userId++)
      {
        if(custInput==names[userId])
        {return 0;}
      }
      userId=0;
      return 0;
  }
*/
