namespace TypesAndDebug
{
  public class TypesAndDebug
  {
    public static int SumYears { get; set; }
    public string? Name;
    public static string nameFolder = string.Empty;
    public static string caminhoPasta = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/TypesAndDebug/bin/Debug";

    /// <summary>
    /// Override in the method ToString
    /// </summary>
    /// <returns>The concatenation of three strings more field Name</returns>
    public override string ToString()
    {
      string textOne = "Você está aprendendo sobre ";
      string textTwo = "Strings em C#, ";
      string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";
      string res = string.Concat(textOne, textTwo, textThree);
      return $" { Name } { res }";
    }

    /// <summary>
    /// this method make the sum of year current with the value into parameter
    /// </summary>
    /// <param name="sumYear"></param>
    /// <returns> Year current more paramater sumYear</returns>
    public static string SumYear(int sumYear)
    {
      Console.WriteLine("Digite quantos anos serão acrescentados:");
      sumYear = Convert.ToInt16(Console.ReadLine());
      int sumed = DateTime.Now.AddYears(sumYear).Year;
      int currentYear = DateTime.Now.Year;
      Console.WriteLine($"Estamos no ano de {currentYear}");
      // int differenceYears = Convert.ToInt32(sumed - currentYear);
      // int sumTotal = differenceYears + currentYear;
      string result = $"Acrescentando os anos estamos em {sumed} ";
      return result;
    }

    /// <summary>
    /// This method call the main method
    /// </summary>
    public static void started()

    {
      Program.Main();
    }
    
    /// <summary>
    /// This method verify wheter the file exist, if not exist call method Delete of class Directory
    /// </summary>
    ///
    public static void deleteFile()
    {
      string pathFile = "/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/TypesAndDebug/bin/Debug/feito/teste.txt";
      File.Delete(pathFile);
      Console.WriteLine("Registro deletado");
    }

    /// <summary>
    /// This method verify wheter the folder exist, if not exist call method Delete of class Directory
    /// </summary>
    public static void deleteFolder()
    {
      Console.WriteLine("Digite o nome da pasta que sera excluida");
      nameFolder = Console.ReadLine();
      caminhoPasta = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/TypesAndDebug/bin/Debug/{nameFolder}";
      if (!Directory.Exists(caminhoPasta))
      {
        createFolder();
      }
      Console.WriteLine("Deseja apagar a pasta");
      char answer = Convert.ToChar(Console.ReadLine());
      if (answer == 's')
      {
        Directory.Delete(caminhoPasta, true);
        Console.WriteLine("Pasta apagada! ");
      }
      else if (answer == 'n')
      {
        Console.WriteLine("opçao de manter a pasta!!");
        started();
      }
    }

    /// <summary>
    /// This method create a folder wheter not exist having how catch an 
    /// ArgumentException
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public static void createFolder()
    {
      Console.WriteLine("Digite o nome da pasta");
      nameFolder = Console.ReadLine();
      caminhoPasta = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/TypesAndDebug/bin/Debug/{nameFolder}";
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

    /// <summary>
    /// This method create a file and can catch for exceptions be a file not exist or folder not found
    /// </summary>
    /// <exception cref="DirectoryNotFoundException"></exception>
    /// <exception cref="FileNotFoundException"></exception>
    public static void createFile()
    {
      string content = "Criado arquivo na pasta feito, tendo como testemunha a gerlane chata";
      string pathCurrent = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/TypesAndDebug/bin/Debug/feito";
      string pathFile = $"/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/TypesAndDebug/bin/Debug/feito/teste.txt";
      
      if (!Directory.Exists(pathCurrent))
      {
        throw new DirectoryNotFoundException("Pasta não encontrada");        
      }
        if (File.Exists(pathFile))
        {
          throw new FileNotFoundException("Arquivo ja existe");
        }
          File.WriteAllText(pathFile, content);
          Console.WriteLine("Arquivo criado com sucesso:");
          started();

    }
    }
  }
