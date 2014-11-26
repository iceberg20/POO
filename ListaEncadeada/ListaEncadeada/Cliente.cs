using System;

namespace ListaEncadeada
{
	public class Cliente
	{
		public Cliente proximo;
		public string nome;
		public Cliente ()
		{
		}
		public Cliente (string nome)
		{
			this.nome = nome;
			this.proximo = null;
		}
		public string GetNome()
		{
			return nome;
		}

		public Cliente GetProximo()
		{
			return this.proximo;
		}
		public void SetProximo(Cliente c)
		{
			this.proximo = c;
		}

	}
}

