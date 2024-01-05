using System.Security.Cryptography.X509Certificates;

namespace ObjectOrientation
{
  public class Client
  {
    public string Name { get; set; }
    public Pet MyPet { get; set; }

    public Client()
    {
      Console.WriteLine("Type your name: ");
      Name = Console.ReadLine();
      MyPet = new Pet();
    }

        public override string ToString()
        {
            return $"O cliente {Name} é proprietario do pet {MyPet.Name} pesando {MyPet.weight}Kg.";
        }
    }
}