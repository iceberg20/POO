using System;

namespace AulaClasse
{
	public class Pessoa
	{
		public string nome;
		private int idade;

		public Pessoa ()
		{

		}

		public void SetIdade(int idade)
		{
			if(idade > 100) 
				Console.WriteLine("Idade invalida!");
			else
				this.idade = idade;
		}

		public int GetIdade()
		{
			return this.idade;
		}


	}
}

