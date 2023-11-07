namespace Functions
{
  public class Person {
    public string? name = string.Empty;
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
  
    public double CalculatingPersonBmi(double weight, double height) {
      return weight / (height * height);
    }
  
    public int CalculateAgeByYear(int yearOfBirth) {
      return DateTime.Now.Year - yearOfBirth;
    }

    public static string ValidateComingOfAge(int age) {
      if (age >= 18)
      {
        return "Pode entrar";
      }
      else
      {
        return $"Não pode entrar voce tem {age} anos só é permitido maiores de 18 anos";
      }
    }
  }
}