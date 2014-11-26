using System;

namespace AulaClasse
{

	class MainClass
	{
	

		public static void Main (string[] args)
		{

			Pessoa p = new Pessoa();

			while (true) {
				Console.WriteLine ("Digite a idade");
				int i = int.Parse (Console.ReadLine ());
				p.SetIdade (i);

				Console.WriteLine ("Sua idade é {0}", p.GetIdade());
				Console.ReadKey ();

			}
		}

	}
}
