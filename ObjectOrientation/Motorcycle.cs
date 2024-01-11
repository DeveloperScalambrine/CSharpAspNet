class Motorcycle
{
  public double TopSpeed { get; set; }
  public bool CanDoWheelies { get; set; }
  public Engine CB750  { get; set; } = new Engine();

  public Motorcycle()
  {
    TopSpeed = 20;
  }

  public void Drive(double distanceKm, double speed)
  {
    if (speed > TopSpeed)
      Console.WriteLine("Your bike can't go that fast!");
    else if (!CB750.IsStarted)
      Console.WriteLine("Your bike isn't turned on!");
    else
    {
      var time = distanceKm / speed;
      Console.WriteLine($"You arrived in {time} hours of the motorcycle.");
    }
  }

  public void DoWheelie()
  {
    if (!CanDoWheelies)
      Console.WriteLine("Your bike can't do wheelies!");
    else if (!CB750.IsStarted)
      Console.WriteLine("Your bike isn't turned on!");
    else
      Console.WriteLine("Your bike is doing a wheelie!");
  }

  public void StartEngine() => CB750.Start();

  public void StopEngine() => CB750.Stop();
}