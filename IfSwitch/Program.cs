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
		*/

			/* Example using while, do while and for and foreach

			string? vacation;
			vacation = Console.ReadLine();
			bool vacationConverted = Convert.ToBoolean(vacation);
			while (vacationConverted == false)
			{
				Console.WriteLine("Trabalhar");
				break;				
			}

			int? count = 0;
			while (count < 10)
			{
				Console.WriteLine("count" + count);
				count+=1;
			}
			do
			{
				Console.WriteLine("count" + count);
				count+=1;
			} while (count < 10);
			for (int count = 0; count < 3; count++)
			{
				Console.WriteLine("numero: " + count);
			}

			string[] names = new string[] { "Hulk", "Thor", "Loki" };
			foreach (var name in names)
			{
				Console.WriteLine(name);
			}
		
			// string[] teachers = new string[] { "Joel", "Tess", "Marlene" };
			// string[] students = new string[] { "Ellie", "Joel", "Abby" };
			// foreach (var teacher in teachers)
			// {
			// 	Console.WriteLine("Professor: " + teacher + ". Estudante:");
			// 	foreach (var student in students)
			// 	{
			// 		if (teacher == student)
			// 			break;
			// 		Console.WriteLine(student);
			// 	}
			// }
			int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2 };
			var count = 0;
			foreach (var vote in votes)
			{
				if (vote > 3)
					continue;
				count++;
			}
			Console.WriteLine(count + " votos válidos ");
		*/

												/* EXERCICIES 
			// int[] myArray = new int[8]{ 1, 2, 3, 3, 1, 9, 7, 8 };
			// int result = NumberTools.CountOf(myArray, 2);
			// Console.WriteLine(result);
			// NumberTools.IndexOf(myArray);
			// int numberOfPair = NumberTools.CountEvenNumbers(myArray);
			// Console.WriteLine(numberOfPair);
			*/
			
		
		}
	}
}