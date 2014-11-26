using System;

namespace Heranca
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ContaComum c = new ContaComum ("123", "José");
			c.Abertura (1000);
			c.Saque (500);
			Console.WriteLine (c.verificaSaldo());
			ContaEspecial e = new ContaEspecial ();
			e.Abertura (1000, 500);
			e.Saque (1200);
			Console.WriteLine (e.verificaSaldo());
			ContaPoupanca p = new ContaPoupanca ();
			p.Abertura (1000);
			p.Rendimento (0.01);
			Console.WriteLine (p.verificaSaldo ());
			Console.ReadKey ();
		}
	}
}
