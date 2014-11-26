using System;

namespace Lista5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Agenda g = new Agenda ();
			string assunto, local;
			DateTime data;
			int op = 1;
			while (op != 0) 
			{
				Console.WriteLine ("Insira um compromisso");
				assunto = Console.ReadLine ();

				data = DateTime.Parse ("10/10/1990");
				local = Console.ReadLine ();
				Compromisso c = new Compromisso (assunto, data, local);
				g.InserirCompromisso (c);
				op = int.Parse (Console.ReadLine());
			}

			int cont = 0;
			while (cont < g.qtd) {
				Console.WriteLine (g.ListarComprimissos () [cont].ToString ());
				cont++;
			}



			Console.ReadKey ();
		}
	}
}
