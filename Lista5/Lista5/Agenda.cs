using System;

namespace Lista5
{
	public class Agenda
	{
		private Compromisso[] compromissos;
		public int qtd;

		public Agenda ()
		{
			this.compromissos = new Compromisso[10];
			qtd = 0;
		}
		public void InserirCompromisso(Compromisso c)
		{
			if (qtd < 10) 
			{
				compromissos [qtd] = c;
				qtd++;
			}
		}

		public Compromisso[] ListarComprimissos()
		{
			return this.compromissos;
		}

	}
}

