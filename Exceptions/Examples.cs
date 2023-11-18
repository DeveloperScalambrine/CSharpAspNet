using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Exceptions
{
  public class Exceptions
  {
    public int NumberOne, NumberTwo;
    public string methodName = string.Empty;
    int result, iterator;
    public string source = "/home/henrique/EstudosCSharp/CsharpAspNet/CSharpAspNet/Exceptions/bin/Debug/net7.0/ExceptionOrResult.txt";
    public void DivideNumbers(int numberOne, int numberTwo)
    {
      StreamWriter str = new StreamWriter(source);
      try
      {
        while (iterator < 3)
        {
          iterator += 1;
          Console.WriteLine("Digite o Numerador: ");
          NumberOne = numberOne;
          NumberOne = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Digite o Denominador: ");
          NumberTwo = numberTwo;
          NumberTwo = Convert.ToInt32(Console.ReadLine());
          result = NumberOne / NumberTwo;
          str.WriteLine($"The value of division is of {NumberOne} / {NumberTwo} it´s: {result}");
        }
      }  
      catch (DivideByZeroException)
      {
        StackFrame sf = new StackFrame();
 
        methodName = sf.GetMethod()!.Name;
        str.WriteLine($"Name of class: {GetType()} Name of method {methodName}");
        throw new DivideByZeroException($"Error when trying to divide a number by zero in the method => {methodName} ");
      }
      finally
      {
        str.Close();
      }
    }

    public string IsExistFile(string path)
    {
      // StreamWriter str = new StreamWriter(path);

      if (!File.Exists(path))
      {
        throw new FileNotFoundException("File not encountered:", source);
      }
      File.Delete(path);
      return path;
    }

    public class Person
    {
      public string Name { get; set; }
      public object Age { get; set; }

      public string ShowName(string name)
      {
        if (name == string.Empty || name == null)
        {
          throw new ArgumentNullException(name, "Nome vazio não é possivel continuarmos com aplicação");
        }
        Name = name;
        return Name;
      }

      public object ShowAge(object age)
      {
        if (!(age is int))
        {
          throw new InvalidDataException("Não é possivel receber outro tipo de dado que não seja numérico(INT)");
        }
        Age = age;
        return Age;
      }

      public object DatasPerson(string name, int age)
      {
        Name = name;
        Age = age;
        return $"Objeto criado que representa uma pessoa tem a propriedade nome no valor de {Name} e a propriedade idade contendo o valor de {Age}";
      }
      public void ListPerson()
      {    

        object[] person = new object[2];
        int foundPosition = 1;
        for (int i = 0; i < person.Length; i++)
        {
          if (foundPosition > person.Length)
          {
            throw new IndexOutOfRangeException("Posição não localizada na lista:");
          }
          person[foundPosition] = DatasPerson(ShowName(Name), Convert.ToInt32(ShowAge(Age)));
          Console.WriteLine(person[foundPosition]);
        }
      }
      public bool VerifyName(string name)
      {
        string storedName = ShowName(Name);
        
        if (name != storedName)
        {
          Console.WriteLine("Processo não finalizado");
          throw new ArgumentException("Nome não localizado em nosso base de dados");
        }
        Console.WriteLine($"{name} foi localizado");
        return true;
        methodName = sf.GetMethod()!.Name; 
        throw new DivideByZeroException($"Error when trying to divide a number by zero in the method => {methodName} ");

      }
    }
  }
}
