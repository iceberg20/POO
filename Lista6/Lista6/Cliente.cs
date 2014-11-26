using System;

namespace Lista6
{
	public class Cliente
	{
		private string nome;
		private string cpf;
		private Cliente socio;
		private double limite;

		public Cliente (string nome, string cpf, double limite)
		{
			this.nome = nome;
			this.cpf = cpf;
			this.limite = limite;
		}

		public void SetSocio(Cliente c)
		{
			this.socio = c;
		}

		public static void AtualizarLimites(Cliente a, Cliente b)
		{
			double limite_a = a.GetLimite ();
			a.SetLimite (a.GetLimite () + b.GetLimite ());
			b.SetLimite (limite_a + b.GetLimite ());
		}

		public double GetLimite()
		{
			return this.limite;
		}

		public void SetLimite(double limite)
		{
			this.limite = limite;
		}
	}
}

