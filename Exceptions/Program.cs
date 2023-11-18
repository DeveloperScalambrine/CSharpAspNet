using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using static Exceptions.Exceptions;

namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        // Criando um arquivo
        // Exceptions CreateFileExceptions = new Exceptions();
        // CreateFileExceptions.DivideNumbers(CreateFileExceptions.NumberOne, CreateFileExceptions.NumberTwo);

        // verificar se existe um arquivo válido retorne o caminho e apague o arquivo
        Exceptions FilesExceptions = new Exceptions();
        string fulllPath = FilesExceptions.IsExistFile(FilesExceptions.source);
        Console.WriteLine(fulllPath);

        // Validação de nome vazio ou nulo, idade sendo do tipo int e se um nome consta na lista
        // Person exc = new Person();
        // string nameReturned = exc.ShowName("Henrique");
        // object ageReturned = exc.ShowAge(37);
        // // exc.ListPerson();
        // bool IsUser = exc.VerifyName("Henrique");
        // string result = (IsUser == true) ? "Processo finalizado" : "Processo não finalizado";
        // Console.WriteLine(result);
      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (FileNotFoundException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (IndexOutOfRangeException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (InvalidDataException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (ArgumentNullException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (ArgumentException e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
      //   Console.WriteLine($"Usando a propriedade de exception classe mais genérica Message: {ex.Message}");
      // }
      // // string[] chemicalProduct = new string[3];
      // try
      // {
      //   chemicalProduct[0] = "Cálcio";
      //   chemicalProduct[1] = "Zinco";
      //   chemicalProduct[2] = "Hidrazina";
      //   chemicalProduct[3] = "Anilina";
      //   for (int i = 0; i < chemicalProduct.Length; i++)
      //   {
      //     Console.WriteLine(chemicalProduct[i]);
      //   }
      // }
      // catch (IndexOutOfRangeException ex)
      // {
      //   Console.WriteLine("Erro Específico, sabemos exatamente o motivo do erro." + ex.Message);
      // }
      // catch (Exception)
      // {
      //   Console.WriteLine("Temos a mensagem, porém é um pouco incerto o que ocorreu.");
      // }
