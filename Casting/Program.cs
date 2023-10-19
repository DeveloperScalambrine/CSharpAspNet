namespace Casting
{
	class Program
	{
		static void Main()
		{
			string userEntry = "54";
			int valueConverted = 0;
			bool canConvert = Int32.TryParse(userEntry, out valueConverted);
			Console.WriteLine(canConvert + " " + valueConverted);
			// long someLongNumber = 516144066604654;
			// int intNumber = Convert.ToInt32(someLongNumber);

			// Console.WriteLine(intNumber);
			//  int n1 = 5;
			//  int n2 = 2;
			//  double te = ((double) n1 / n2);
			// int intResult = 5 / 2;
			// double te = ((double) intResult / );

			// Console.WriteLine(te);

		}
	}
}