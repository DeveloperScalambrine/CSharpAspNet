namespace IfSwhitch
{

  /*  Problema: Uma rede de supermercado precisa saber, dentro de uma lista de produtos vendidos no mês, quantas vezes um determinado produto foi vendido, ou seja, a quantidade de vezes que um determinado número aparece em uma coleção de outros números. Para isso, vamos precisar percorrer todos os elementos dessa coleção comparando com o número que estamos procurando.
  public static class NumberTools {

    public static int CountOf(int[] numbers, int value) {
      var count = 0;

      foreach (var number in numbers)
      {
        if (number == value) count+=1;

      }
        return count;
    } 
   */

  /* Como uma pessoa programadora, você foi contratada por uma empresa de produtos eletrônicos para construir uma função que identifique a posição de vendas de um determinado produto em um ranking de produtos vendidos.Você precisará construir uma função que retorna a posição que um valor está dentro de um array ou retornará -1 quando não encontrar.

   // public static int IndexOf(int[] ranking) {
   //   int classification = 9;
   //   int position = -1;
   //   foreach (var pos in ranking)
   //   {
   //     if (pos == classification)
   //     {
   //       position = pos;          
   //       break;       
   //     }
   //   }
   //   return position;
   // }

*/

  /* Para exemplificar o uso do continue, vamos resolver o seguinte problema: Uma determinada indústria tem uma lista de quantidade de produtos produzidos por lote. Como esses produtos são vendidos em pares, a indústria precisa identificar a quantidade de lotes prontos para venda, ou seja, vamos construir uma função que conta e retorna a quantidade de número pares dentro de um array de números inteiros.

  public static int CountEvenNumbers(int[] numbers) {
    var count = 0;
    foreach (var number in numbers)
    {
      if (number%2 == 0) 
      {            
          count++;
          continue;
    }
    }
    return count;
  }
*/
}


