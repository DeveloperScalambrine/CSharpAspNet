using System.Diagnostics;

namespace TypesAndDebug
{
  class Program
  {
    public static void Main()
    {
      /* Criando uma instancia de TypesAndDebug para vermos a sobre escrita do metodo ToString

        TypesAndDebug greet = new TypesAndDebug
        {
          Name = "Carlos"
        };
        Console.WriteLine(greet);
      */
      
      /* Criando instancia de TypesAndDebug chamando o metodo estatico 
         sumYear que tem como propriedade SumYears 
         Console.WriteLine(TypesAndDebug.SumYear(TypesAndDebug.SumYears));
      */

      /* Setando as opções para criar deletar arquivos e pastas
      try
      {
       Console.WriteLine("Escolha a opção que deseja: ");
       Console.WriteLine("1 > Criar Pasta");
       Console.WriteLine("2 > Criar Arquivo");
       Console.WriteLine("3 > Deletar Pasta");
       Console.WriteLine("4 > Deletar Arquivo");
       Console.WriteLine("5 > Sair da aplicação");
       int result = Convert.ToInt32(Console.ReadLine());
       if (result == 1)
       {
         TypesAndDebug.createFolder();
       }
       else if (result == 2)
       {
         TypesAndDebug.createFile();
       } else if (result == 3)
       {
         TypesAndDebug.deleteFolder();
       } else if (result == 4) {
         TypesAndDebug.deleteFile();
       } else if (result == 5) {
         Environment.Exit(0);
       }
     }
     catch (ArgumentException e)
     {
       Console.WriteLine(e.Message);
     }
     catch (FileNotFoundException e)
     {
       Console.WriteLine(e.Message);
     }
     */

      /* Exemplo do uso do metodo Split para separarmos os emails com (;)
       
       string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com;email4@trybe.com;email5@trybe.com;email6@trybe.com";
       string[] arrayEmails = emails.Split(";");
       
       */
    }
  }
}