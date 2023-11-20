namespace TypesAndDebug
{
  public class TypesAndDebug
  {
    public string Name;
    public static string nameFolder = string.Empty;
    public static string caminhoPasta = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/";

    // public override string ToString()
    // {
    //   // string textOne = "Você está aprendendo sobre ";
    //   // string textTwo = "Strings em C#, ";
    //   // string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";
    //   // string res = string.Concat(textOne, textTwo, textThree);
    //   // return $" {Name } {res}";
    //   // var ff = DateTime.Now.AddYears(3);
    //   // int dt = DateTime.Now.Year;
    //   // return $"daqui tres anos estaremos em {ff} este anos estamos em {dt}";
    // }

    // public string  Interpolation(string name)
    // {
    //   string subject = $"Olá, {name}! Boas vindas ao sistema parceiro da Trybe!";
    //   // Console.WriteLine(subject);
    //   return subject;
    // }
    public static string SumYear(int sumYear)
    {
      int sumed = DateTime.Now.AddYears(sumYear).Year;
      int currentYear = DateTime.Now.Year;
      Console.WriteLine($"Estamos no ano de {currentYear}");
      int differenceYears = Convert.ToInt32(sumed - currentYear);
      int sumTotal = differenceYears + currentYear;
      string result = $"Acrescentando os anos estamos em {sumTotal} ";
      return result;
    }

    public static void started()
    {
      Program.Main();
    }
    public static void deleteFolder()
    {
      Console.WriteLine("Digite o nome da pasta que sera excluida");
      nameFolder = Console.ReadLine();
      caminhoPasta = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/{nameFolder}";
      if (!Directory.Exists(caminhoPasta))
      {
        createFolder();
      }
      Console.WriteLine("Deseja apagar a pasta");
      char answer = Convert.ToChar(Console.ReadLine());
      if (answer == 's')
      {
        Directory.Delete(caminhoPasta);
        Console.WriteLine("Pasta apagada! ");
      }
      else if (answer == 'n')
      {
        Console.WriteLine("opçao de manter a pasta!!");
        started();
      }
    }
    public static void createFolder()
    {
      Console.WriteLine("Digite o nome da pasta");
      nameFolder = Console.ReadLine();
      caminhoPasta = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/{nameFolder}";
      if (Directory.Exists(caminhoPasta))
      {
        Console.WriteLine("Pasta ja existe não é possivel gravar Deseja apaga - la ? / s / n");
        char res = Convert.ToChar(Console.ReadLine());
        char answer = 's';
        if (answer.Equals(res))
        {
          deleteFolder();
        }
        else
        {

          started();
        }
      }
      Console.WriteLine("Deseja criar uma pasta");
      char answern = Convert.ToChar(Console.ReadLine());
      if (answern != 's')
      {
        throw new ArgumentException("Opção de não criar pasta e programa finalizado!!!");
      }

      Directory.CreateDirectory(caminhoPasta);
      Console.WriteLine("Pasta criada! ");
    }

    public static void createFile()
    {
      string content = "Criado arquivo na pasta 2023 para bla bla bla";
      string pathFile = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/2023/{content}.txt";
      if (!File.Exists(pathFile))
      {
        throw new DirectoryNotFoundException("Pasta não encontrado tente outra pasta");
      }
      File.WriteAllText(pathFile, content);
      Console.WriteLine("Arquivo criado com sucesso:");
    }
  }
}