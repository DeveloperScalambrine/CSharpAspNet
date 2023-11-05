namespace Array
{
  public class MyExpenses
  {
    public double[] expenseCost;

    public int getNumberOfExpenses()
    {
      Console.WriteLine("Type the quantity of expenses");
      int quantityExpenses = Convert.ToInt32(Console.ReadLine());
      return quantityExpenses;
    }

    public void expense()
    {
        double totalExpenses = 0;
      for (int i = 0; i < expenseCost.Length; i++)
      {
        Console.WriteLine("Type a value of cost");
        expenseCost[i] = Convert.ToDouble(Console.ReadLine());
        totalExpenses += expenseCost[i];
      }
        Console.WriteLine($"values to be payment {string.Join(" , ", expenseCost)}");
        Console.WriteLine("The total of expenses its: " + totalExpenses);

    }
  }
}