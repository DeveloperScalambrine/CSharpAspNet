namespace Functions
{
  class Program
  {
    static void Main(string[] args)
    {
      // string[] persons = new string[2];
      Person carlos = new Person();
      // for (int i = 0; i < persons.Length; i++)
      // {
        
      //   carlos.CalculatingPersonBmi();
      //   persons[i] = carlos.name;
      // }
      // Console.WriteLine($"Peoples registered: {string.Join(" , ", persons)}");
      // double result = carlos.CalculatingPersonBmi(73,1.70);
      // Console.WriteLine(Math.Round(result));
      int increment = 0;
      int age = carlos.CalculateAgeByYear(2011);
      while (increment < 5)
      increment+=1;
      {
      Console.WriteLine(Person.ValidateComingOfAge(age));
      }
      Console.WriteLine(increment);
    }
  }
}