using System;

namespace AulaClasse
{
	public class Contato
	{
		private string nome;
		private string fone;
		private string email;
		private DateTime nasc;

		public Contato()
		{
		}

		public Contato(string nome, string fone, string email, DateTime nasc)
		{
			this.nome = nome;
			this.fone = fone;
			this.email = email;
			this.nasc = nasc;
		}

		public void SetNome(string nome)
		{
			this.nome = nome;
		}

		public void SetFone(string fone)
		{
			this.fone = fone;
		}

		public void SetEmail(string email)
		{
			this.email = email;
		}

		public void SetNasc(DateTime nasc)
		{
			this.nasc = nasc;
		}

		public string GetNome()
		{
			return nome;
		}

		public string GetFone()
		{	
			return fone;
		}

		public string GetEmail()
		{
			return email;
		}

		public DateTime GetNasc()
		{
			return nasc;
		}





	}
}

