using System;

namespace Lista5_Q6
{
	public class Cone : Figura3D
	{
		private double raio;
		private double altura;

		public Cone (double raio, double altura)
		{
			this.raio = raio;
			this.altura = altura;
		}

		public override double Volume ()
		{
			return (Math.PI * raio * raio * altura) / 3.0;
		} 

	}
}

