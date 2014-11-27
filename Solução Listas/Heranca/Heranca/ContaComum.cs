using System;

namespace Heranca
{
	public class ContaComum
	{
		private string NumConta;
		protected double Saldo;
		private string Titular;

		public ContaComum ()
		{

		}

		public ContaComum (string numConta, string titular)
		{
			this.NumConta = numConta;
			this.Titular = titular;
		}

		public void Abertura(double saldo)
		{
			this.Saldo = saldo;
		}

		public void Depositar(double  valor)
		{
			this.Saldo += valor;
		}
		public virtual void Saque(double valor)
		{
			if (valor <= this.Saldo)
				Saldo -= valor;
		}
		public double verificaSaldo()
		{
			return Saldo;
		}


	}
}

