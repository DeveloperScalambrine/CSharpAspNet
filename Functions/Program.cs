namespace Functions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] persons = new string[2];
      Person carlos = new Person();
      // carlos.CalculatingPersonBmi(carlos.weight, carlos.height);
      for (int i = 0; i < persons.Length; i++)
      {
        
        carlos.CalculatingPersonBmi();
        persons[i] = carlos.name;
      }
      Console.WriteLine($"Peoples registered: {string.Join(" , ", persons)}");
      
    }
  }
}