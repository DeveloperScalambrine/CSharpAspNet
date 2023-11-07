namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      // try
      // {
      //   Exceptions exc = new Exceptions();
      //   exc.DivideNumbers(10, 0);
      // }
      // catch (DivideByZeroException ex)
      // {        
      //   Console.WriteLine($"Usando a propriedade de exception Message: {ex.Message}");        
      // }
      // catch (Exception ex) {
      //   Console.WriteLine($"Usando a propriedade de exception classe mais genérica Message: {ex.Message}");
      // }
      string[] chemicalProduct = new string[3];

      try
      {
        chemicalProduct[0] = "Cálcio";
        chemicalProduct[1] = "Zinco";
        chemicalProduct[2] = "Hidrazina";
        chemicalProduct[3] = "Anilina";
        for (int i = 0; i < chemicalProduct.Length; i++)
        {
          Console.WriteLine(chemicalProduct[i]);
        }
      }
      catch (IndexOutOfRangeException ex)
      {
        Console.WriteLine("Erro Específico, sabemos exatamente o motivo do erro." + ex.Message);
      }
      catch (Exception)
      {
        Console.WriteLine("Temos a mensagem, porém é um pouco incerto o que ocorreu.");
      }

    }
  }
}