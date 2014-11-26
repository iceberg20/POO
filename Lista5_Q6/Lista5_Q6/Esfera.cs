using System;

namespace Lista5_Q6
{
	public class Esfera : Figura3D
	{	
		private double raio;

		public Esfera (double raio)
		{
			this.raio = raio;
		}

		public override double Volume ()
		{
			return  (4 * Math.PI * Math.Pow (raio, 3))/3.0;
		}

	}
}

