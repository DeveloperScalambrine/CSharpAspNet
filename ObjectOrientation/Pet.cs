namespace ObjectOrientation
{
  public class Pet
  {
    public double weight { get; set; }
    public string Name { get; set; }
    public Pet()
    {
      Console.WriteLine("Type the weight your pet: ");
      weight = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Type name of your pet: ");
      Name = Console.ReadLine();
    }
  }
}
