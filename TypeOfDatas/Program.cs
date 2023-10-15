class Program
{
  static void Main()
  {
    /* Input of data of two ways note that the method 
    Parse we have an warning in the line twelve
    */
    Console.WriteLine("Type a date of type integer");
    int Age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type a date of type decimal");
    decimal Average = decimal.Parse(Console.ReadLine());
    
    Console.WriteLine("Type a date of type boolean");
    bool permission = Convert.ToBoolean(Console.ReadLine());
    
    Console.WriteLine("Type a date of type string");
    string? Name = Console.ReadLine();

  Console.WriteLine("Value inserted in INTEGER > " + Age + " Value inserted in DECIMAL > " + Average + " Value inserted in BOOLEAN > " + permission + " Value inserted in INTEGER > " + Name );
  }
}