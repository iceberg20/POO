using System;

namespace Lista6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Cliente joao = new Cliente ("joao", "88888", 600);
			Cliente italo = new Cliente ("italo", "99999", 300);
			Console.WriteLine ("Limite do cliente italo = {0:c}", italo.GetLimite());
			Console.WriteLine ("Limite do cliente Joao = {0:c}", joao.GetLimite ());
			Console.WriteLine ("Italo e joao agora são socios!");
			italo.SetSocio (joao);
			joao.SetSocio (italo);
			Cliente.AtualizarLimites (italo, joao);
			Console.WriteLine ("Limite do cliente italo atualizado para {0:c}", italo.GetLimite ());
			Console.WriteLine ("Limite do cliente joao atualizado para {0:C}", joao.GetLimite ());
			Console.ReadKey ();
		}
	}
}
