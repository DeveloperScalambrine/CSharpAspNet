namespace IfSwhitch
{
	class Program
	{
		static void Main(string[] args)
		{
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

		}
	}
}