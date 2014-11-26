using System;

namespace ListaEncadeada
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Cliente a = new Cliente("Jose");
			Cliente b = new Cliente("Pedro");
			Cliente c = new Cliente("Mario");
			Lista l = new Lista ();
			l.AdicionarCliente (a);
			l.AdicionarCliente (b);
			l.AdicionarCliente (c);
			l.ListarCliente ();
			Console.ReadKey ();
		}
	}
}
