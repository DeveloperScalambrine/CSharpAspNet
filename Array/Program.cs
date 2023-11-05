namespace Array
{
  class Program
  {
    static void Main(string[] args)
    {
      
      // string[] names = new string[3];
      //  string teste = names.GetType().Name;
      //  if (teste == "Doublee[]")
      //  {
      //     Console.WriteLine("ok");
      //  } else {
      //     Console.WriteLine("Não");
      //  }
      // int[] names = new int[3];
      // int teste = names.Count();
      // System.Console.WriteLine(teste);
      // int[] myFirstArray1 = new int[] {1, 2, 3, 4};
      // int[] myFirstArray2 = {5, 6, 7, 8};
      // Console.WriteLine($" {myFirstArray1[3]} {myFirstArray2[0]}");
      // int[,] multiDimensionalArray = { { 1, 2, 3, 4} , {5, 6, 7, 8}};
      // System.Console.WriteLine(multiDimensionalArray[1,0]);
      
      MyExpenses expenses = new MyExpenses();
      // Na linha abaixo o field qtd recebe o retorno do metodo getNumberOfExpenses
      // que por sua vez retorna a quantidade de boletos a pagar, adicionando este retorno
      // para definir o tamanho do array que delimitara a quantidade de contas a pagar. 
      int qtd = expenses.getNumberOfExpenses();
      expenses.expenseCost = new double[qtd];
      // O metodo abaixo expense solicita ao usuario que digite o valor das contas a pagar
      expenses.expense();
    }
  }
}