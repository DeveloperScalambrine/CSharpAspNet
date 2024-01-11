public class Car
{
  public int TopSpeed { get; set; }
  public bool IsAutomatic { get; set; }
  public int NumberOfSeats { get; set; }
  public int EngineHorsepower { get; set; }
  public int EngineTorque { get; set; }
  public int EngineCapacity { get; set; }
  public bool IsEngineStarted { get; set; }

  public Car()
  {
    TopSpeed = 10;
  }
  public void Drive(double distanceKm, double speed)
  {
    if (speed < 0) {
      throw new NullReferenceException("Put gasolyne");
    }

    if (speed > TopSpeed)
    {
      Console.WriteLine("Your car can't go that fast!");
    }
    else if (!IsEngineStarted)
    {
      Console.WriteLine("Your car isn't turned on!");
    }
    else
    {
      double time = distanceKm / speed;
      Console.WriteLine($"You arrived in {time} hours.");
    }
    
  }
  public void StartEngine()
  {
    IsEngineStarted = true;
    Console.WriteLine("Engine started.");
  }

  public void StopEngine()
  {
    IsEngineStarted = false;
    Console.WriteLine("Engine stopped.");
  }
}
