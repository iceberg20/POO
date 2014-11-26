using System;

namespace Heranca
{
	public class ContaEspecial : ContaComum
	{
		private double limite;

		public ContaEspecial ()
		{
		}

		public void Abertura (double saldo, double limite)
		{
			base.Abertura (saldo);
			this.limite = limite;
		}

		public override void Saque(double valor)
		{
			if (valor <= (Saldo + limite))
				Saldo -= valor;
		}
	}
}

