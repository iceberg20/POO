using System;

namespace Heranca
{
	public class ContaPoupanca : ContaComum
	{
		public ContaPoupanca ()
		{
		}

		public void Rendimento(double juros)
		{
			Saldo *= (1 + juros);
		}
	}
}

