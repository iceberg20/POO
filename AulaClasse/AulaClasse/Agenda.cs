using System;

namespace AulaClasse
{
	public class Agenda
	{
		private int qtd;
		private Contato[] contatos;



		public Agenda()
		{
			contatos = new Contato[50];
		}

		public void AdicionarContato(Contato c)
		{
			if (qtd < 50) 
			{
				contatos [qtd] = c;
				qtd++;
			} else
				Console.WriteLine ("Capacidade Esgotada");
		}

		public void ListarContatos()
		{
			for(int i = 0; i < qtd; i++)
			{
				Console.WriteLine ("{0} {1} {2} {3}",
					contatos [i].GetNome (),
					contatos [i].GetFone (),
					contatos [i].GetEmail (),
					contatos [i].GetNasc ());

			}
		
		}

		public void ListarAniversariantes(int mes)
		{
			for (int i = 0; i < qtd; i++) {
				if (contatos [i].GetNasc ().Month == mes) {
					Console.WriteLine ("{0} {1} {2} {3}",
						contatos [i].GetNome (),
						contatos [i].GetFone (),
						contatos [i].GetEmail (),
						contatos [i].GetNasc ());
				}
			}
		}
	}
}

