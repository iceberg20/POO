using System;

namespace Lista3
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			LojaDeVeiculos loja = new LojaDeVeiculos();

			int op;

			Console.WriteLine("Menu");
			Console.WriteLine("1- Adicionar veiculo:");
			Console.WriteLine("2- Remover veiculo:");
			Console.WriteLine("3- Listar todos os veiculos:");
			Console.WriteLine("4- Listar veiculos por fabricate, modelo ou ano:");
			Console.WriteLine ("5- Buscar Veiculo por faixa de preço:");
			Console.WriteLine("0-Para sair:");

			op = int.Parse(Console.ReadLine());



			while (op != 0) 
			{
				switch (op) 
				{
				case 1:
					loja.AdicionarCarros();
					break;
				case 3:
					loja.ListarTodos ();
					break;
				default:
					Console.WriteLine ("Obrigado por utilizar nosso sistema!");
					break;
				}

				Console.WriteLine("Menu");
				Console.WriteLine("1- Adicionar veiculo:");
				Console.WriteLine("2- Remover veiculo:");
				Console.WriteLine("3- Listar todos os veiculos:");
				Console.WriteLine("4- Listar veiculos por fabricate, modelo ou ano:");
				Console.WriteLine ("5- Buscar Veiculo por faixa de preço:");
				Console.WriteLine("0-Para sair:");
				op = int.Parse(Console.ReadLine());


			}



	



		}
	}
}
