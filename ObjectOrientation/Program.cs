namespace ObjectOrientation
{
  class Program
  {
    static void Main(string[] args)
    {

      Client[] clients = new Client[3];

      Client first = new Client();
      Client second = new Client();
      Client third = new Client();
      clients[0] = first;
      clients[1] = second;
      clients[2] = third;

      foreach (var client in clients)
      {
        Console.WriteLine(client);
      }

    }

  }
}

