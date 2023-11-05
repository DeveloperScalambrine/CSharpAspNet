namespace Functions
{
  public class Person {
    public string? name = string.Empty;
    // public double weight, height;
    public void  CalculatingPersonBmi() {
      double result, weight, height;
      Console.WriteLine("Type your Name: ");
      name = Console.ReadLine();
      Console.WriteLine("Type your Weight");
      weight = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Type your Height");
      height = Convert.ToDouble(Console.ReadLine());
      result = weight / (height * height);
      Console.WriteLine($"{name} YOUR BMI IS: {result}");
    }
  
    // public void CalculatingPersonBmi(double weight, double height) {
    //   double result;
    //   Console.WriteLine("Type your Name: ");
    //   name = Console.ReadLine();
    //   Console.WriteLine("Type your Weight");
    //   weight = Convert.ToDouble(Console.ReadLine());
    //   Console.WriteLine("Type your Height");
    //   height = Convert.ToDouble(Console.ReadLine());
    //   result = weight / (height * height);
    //   Console.WriteLine($"{name} YOUR BMI IS: {result}");
    // }
  }
}