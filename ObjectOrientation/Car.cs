public class Car
{
  public int TopSpeed { get; set; }
  public bool IsAutomatic { get; set; }
  public int NumberOfSeats { get; set; }
  public Engine v8 { get; set; } = new Engine();
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
    else if (!v8.IsStarted)
    {
      Console.WriteLine("Your car isn't turned on!");
    }
    else
    {
      double time = distanceKm / speed;
      Console.WriteLine($"You arrived in {time} hours of the car.");
    }
    
  }
  public void StartEngine()
  {
    // IsEngineStarted = true;
    // Console.WriteLine("Engine started.");
    v8.Start();
  }

  public void StopEngine() => v8.Stop();

  // IsEngineStarted = false;
  // Console.WriteLine("Engine stopped.");
}
