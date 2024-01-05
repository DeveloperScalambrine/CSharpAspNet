namespace ObjectOrientation
{
  public class Rocket
  {
    public string Name { get; set; }

    int _fuel;
    public int Fuel 
    {
      get {return _fuel;}

      set {
            if(value == 0 || value < 0){
              throw new ArgumentOutOfRangeException(); 
            }
              
              _fuel = value;
          }
    }
    public decimal Price { get; set; }
    

    public Rocket(string name, decimal price)
    {
      Name = name;
      Price = price;
      Fuel = 10;
    }

        public override string ToString()
        {
            return $" Name of Rocket it´s {Name} Value it´s {Price} fuel it´s {Fuel}";
        }
  }
}
     