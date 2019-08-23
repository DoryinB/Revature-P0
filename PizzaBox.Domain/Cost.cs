namespace PizzaBox.Domain
{
  public class Cost
  {
    private decimal cost;
    public Cost(){cost = 0.00m;}

    public decimal addCost(decimal additional)
    {
      cost = cost + additional;
      return cost;
    }

    public decimal subCost(decimal minus)
    {
      cost = cost - minus;
      return cost;
    }
  }
}