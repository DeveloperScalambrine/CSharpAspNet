using System.Diagnostics;
namespace Exceptions {
  
  public class Exceptions {
    string methodName = string.Empty;
    int res;
    
    public int DivideNumbers(int numberOne, int numberTwo)
    {
      try 
      {
        res =  numberOne / numberTwo;
        Console.WriteLine($"O valor da divisão é: {res}");     
      }
      catch (DivideByZeroException)
      {
        StackFrame sf = new StackFrame();
        methodName = sf.GetMethod()!.Name; 
        throw new DivideByZeroException($"Erro ao tentar realizar a divisão por um numero zero no método => {methodName} ");
      }
      return res;
    }
  }
}