using System;

namespace AulaClasse
{
	public class Conta
	{
		private int saldo;
		private int numConta;
		private string nome;

		public Conta ()
		{
		}

		public void SetNumeroConta(int n)
		{
			numConta = n;
		}

		public void SetSaldo(int s)
		{
			saldo = s;
		}

		public void SetNome(string n)
		{
			nome = n;
		}

		public void depositar(int valor)
		{
			saldo = saldo + valor ;
		}

		public bool Sacar(int valor)
		{
			if (valor > saldo) {
				return false;
			}
			else {
				saldo-= valor;
				return true;
			}
		}

		public void consultarSaldo()
		{
			Console.WriteLine ("Seu saldo é {0}",saldo);
		}






	}
}

