namespace IfSwhitch
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Example using structs of condition
			 
			string Situation = "";

			Console.WriteLine("Type a value of note:");
			double Note = Convert.ToDouble(Console.ReadLine());
			if (Note >= 7)
			{
				Situation = "Aprovado";
				Console.WriteLine(Situation);
			}
			else
			{
				Situation = "Reprovado";
				Console.WriteLine(Situation);
			}
		*/

			/* Example using struct switch case
			Console.WriteLine("Digite um numero: ");
			int number = Convert.ToInt32(Console.ReadLine());
			switch (number)
			{
				case > 0:
				Console.WriteLine("Maior que zero");
				break;
				case 0:
				Console.WriteLine("Igual a zero");
				break;
				default:
				Console.WriteLine("Menor que zero");
				break;		
			}
		*/
			Console.WriteLine("Type a count of polygon");
			IdentifyPolygon(Convert.ToInt32(Console.ReadLine()));
		}
		public static string IdentifyPolygon(int sideCount)
		{
			string? name;
			switch (sideCount)
			{
				case < 3:
					name = "Não é um polígono";
					break;
				case 3:
					name = "Triângulo";
					break;
				case 4:
					name = "Quadrado";
					break;
				case 5:
					name = "Pentágono";
					break;
				default:
					name = "Polígono não identificado";
					break;
			}
			return name;
		}
	}
}