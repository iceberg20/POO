using System;

namespace Lista3
{
	public class LojaDeVeiculos
	{
		private Veiculo[] estoque;
		private string nome;
		private string endereco;
		private int qtdEstoque;
		private int capacidade =20 ;

		public LojaDeVeiculos ()
		{
			estoque = new Veiculo[20];
		}

		public void AdicionarCarros()
		{
			Console.WriteLine ("Digite o Fabricante:");
			string f = Console.ReadLine ();
			Console.WriteLine ("Digite o modelo:");
			string m = Console.ReadLine ();
			Console.WriteLine ("Digite o ano:");
			int a = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Digite o preco:");
			double p = double.Parse(Console.ReadLine ());

			Veiculo v = new Veiculo (f, m, a, p);

			if (qtdEstoque < capacidade)
			{
				estoque [qtdEstoque] = v;
				qtdEstoque++;
				Console.WriteLine("Veiculo adicionado com sucesso!");
			
			}
			else
			{
				Console.WriteLine("Estoque lotado!");
			}

		}

		public int GetQtdEstoque()
		{
			return this.qtdEstoque;
		}

		public void ListarTodos()
		{
			for (int i = 0; i < qtdEstoque; i++)
			{
					Console.WriteLine (">>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<");
					Console.WriteLine ("Fabricante = {0}", estoque[i].GetFabricante());
					Console.WriteLine ("Modelo = {0}", estoque[i].GetModelo());
					Console.WriteLine ("Ano = {0}", estoque[i].GetAno());
					Console.WriteLine ("Preço {0}", estoque[i].GetPreco());
					Console.WriteLine (">>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<");
			}


		}
		public void PesquisaPorFabricante(string fabricante)
		{
			for (int i = 0; i < qtdEstoque; i++)
			{
				if (estoque[i].GetFabricante() == fabricante) 
				{
					Console.WriteLine ("Fabricante = {0}", estoque[i].GetFabricante());
					Console.WriteLine ("Modelo = {0}", estoque[i].GetModelo());
					Console.WriteLine ("Ano = {0}", estoque[i].GetAno());
					Console.WriteLine ("Preço {0}", estoque[i].GetPreco());
				}
			}

		}
	}
}

