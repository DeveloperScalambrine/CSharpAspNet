namespace ObjectOrientation
{
  class Program
  {
    static void Main(string[] args)
    {
      var firstRocket = new Rocket("Apollo 11", 250000);
      var secondRocket = new Rocket("Falcon 9", 300000);
      Console.WriteLine(firstRocket);
      Console.WriteLine(secondRocket);
    
      
    }

  }
}

