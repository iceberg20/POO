using System;

namespace Lista3
{
	public class Veiculo
	{
		private string fabricante;
		private string modelo;
		private int ano;
		private double preco;

		public Veiculo ()
		{
		}

		public Veiculo (string fabricante, string modelo, int ano, double preco)
		{
			this.fabricante = fabricante;
			this.modelo = modelo;
			this.ano = ano;
			this.preco = preco;
		}

		public string GetFabricante()
		{
			return this.fabricante;
		}

		public string GetModelo()
		{
			return this.modelo;
		}

		public int GetAno()
		{
			return this.ano;
		}

		public double GetPreco()
		{
			return this.preco;
		}

	}
}

