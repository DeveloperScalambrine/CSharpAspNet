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
        Motorcycle hornet = new Motorcycle();
         Car carCorolla = new Car();
         carCorolla.StartEngine();
         hornet.StartEngine();
         if (carCorolla.v8.IsStarted == true && hornet.CB750.IsStarted == true)
         {
            carCorolla.StopEngine();
            hornet.StopEngine();
         } if (carCorolla.v8.IsStarted == false && hornet.CB750.IsStarted == false) {
            carCorolla.StartEngine();
            hornet.StartEngine();
         }    
         carCorolla.Drive(11, 10);
         hornet.Drive(20, 20);
      }
      catch (NullReferenceException e)
      {        
        Console.WriteLine(e.Message);
      }
    }
  }
}