namespace ObjectOrientation
{
  class Program
  {
    static void Main(string[] args)
    {
      // var firstRocket = new Rocket("Apollo 11", 250000);
      // var secondRocket = new Rocket("Falcon 9", 300000);
      // Console.WriteLine(firstRocket);
      // Console.WriteLine(secondRocket);
    
      // var firstClient = new Client();
      // Console.WriteLine(firstClient);
      try
      {
         Car carCorolla = new Car();
         carCorolla.StartEngine();
         if (carCorolla.IsEngineStarted == true)
         {
            carCorolla.StopEngine();
         } if (carCorolla.IsEngineStarted == false) {
            carCorolla.StartEngine();
         }    
         carCorolla.Drive(12, 10);
      }
      catch (NullReferenceException e)
      {        
        Console.WriteLine(e.Message);
      }
    }
  }
}