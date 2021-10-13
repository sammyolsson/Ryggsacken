using System;

namespace Ryggsack
{
	class Program
	{
		static void Main(string[] args)
		{
			bool minBool = true;
			string item = "";

			while (minBool)
			{
				// Meny
				Console.WriteLine("Välkommen till ryggsäcken!");
				Console.WriteLine("[1] - Lägg till ett föremål");
				Console.WriteLine("[2] - Skriv ut innehållet");
				Console.WriteLine("[3] - Rensa innehållet");
				Console.WriteLine("[4] - Avsluta");
				Console.WriteLine("Välj:");

				int meny = Convert.ToInt32(Console.ReadLine());

				switch (meny)
				{
					case 1:
						// användaren deklarar föremålet
						Console.Write("Skriv in ditt föremål: ");
						item = Console.ReadLine();
						Console.WriteLine("Du skrev in föremålet: " + item);
						break;

					case 2:
						// skriver ut föremålet
						Console.WriteLine("Ditt föremål är: " + item);
						break;

					case 3:
						// rensar föremålet
						item = "";
						break;

					case 4:
						// avslutar programmet
						minBool = false;
						break;

					default:
						// skrivs ut varje gång användaren väljer något annat än 1-4
						Console.WriteLine("Du måste välja mellan 1-4.");
						break;
				}
			}
		}
	}
}

