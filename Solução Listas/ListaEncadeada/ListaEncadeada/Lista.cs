using System;

namespace ListaEncadeada
{
	public class Lista
	{
		public Cliente primeiro; //Primeiro = null
		public Cliente ultimo;   //Ultimo = null

		public Lista ()
		{
			this.primeiro = null;
			this.ultimo = null;
		}

		public void AdicionarCliente(Cliente c)
		{
			if (primeiro == null) {
				primeiro = c;
			} else {
				ultimo.SetProximo (c);
			}
				ultimo = c;
		 }



		public void ListarCliente()
		{
			if (primeiro == null) {
				Console.WriteLine ("Lista vazia");
			} else {
			
				Cliente aux = primeiro;
				while (aux != null) {
					Console.WriteLine (aux.GetNome ());
					aux = aux.GetProximo ();

				}
			
			}

	}
}
}
