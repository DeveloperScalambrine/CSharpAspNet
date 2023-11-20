using System.Diagnostics;

namespace TypesAndDebug
{
  class Program
  {
    public static void Main()
    {
      try
      {
        Console.WriteLine("Escolha a opção que deseja: ");
        Console.WriteLine("1 > Criar Pasta");
        Console.WriteLine("2 > Deletar Pasta");
        Console.WriteLine("3 > Sair da aplicação");
        int result = Convert.ToInt32(Console.ReadLine());
        if (result == 1)
        {
          TypesAndDebug.createFolder();
        }
        else if (result == 2)
        {
          TypesAndDebug.deleteFolder();
        } else if (result == 3)
        {
          Environment.Exit(0);
        } 
      }
      catch (ArgumentException e)
      {
        Console.WriteLine(e.Message);
      }
      
      // Criando mantendo ou apagando a pasta
      // try
      // {
      //   TypesAndDebug.createFolder(); 
      //   // TypesAndDebug.createFile();
      // }
      // catch (DirectoryNotFoundException e)
      // {
      //   e.Message.ToString();
      // }
      // catch (IOException e)
      // {
      //   Console.WriteLine(e.Message);
      //   char res = Convert.ToChar(Console.ReadLine());
      //   char answer = 's';

      //   if (answer.Equals(res))
      //   {
      //     Directory.Delete(TypesAndDebug.caminhoPasta);
      //     Console.WriteLine("Pasta apagada! ");
      //   } else {
      //     Console.WriteLine("Pasta mantida");
      //   }
      // }
      // finally
      // {
      //  Console.WriteLine("Metodo executado 1(Criando a pasta) 2(Apagando a pasta) 3(Mantendo a pasta)");
      // } 
      // // int dt = DateTime.Now.AddYears(2).Year;
      // int de = DateTime.Now.Year;
      // int res = dt - de;
      // int sum = res + de;
      // Console.WriteLine(sum);
      // Console.WriteLine("Digite quantos anos serão acrescentados: ");
      // int sumYear = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine(TypesAndDebug.SumYear(sumYear));
      // TypesAndDebug subject = new TypesAndDebug();
      // var dateOnly = date.Date;
      // Console.WriteLine(dateOnly.ToString());
      // System.Console.WriteLine(subject.Interpolation("carlos"));
      //  System.Console.WriteLine(subject);
      // TypesAndDebug greet = new TypesAndDebug
      // {
      //   Name = "Carlos"
      // };
      //   Console.WriteLine(greet);      
      // string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com;email4@trybe.com;email5@trybe.com;email6@trybe.com";
      // string[] arrayEmails = emails.Split(";");

    }
  }
}