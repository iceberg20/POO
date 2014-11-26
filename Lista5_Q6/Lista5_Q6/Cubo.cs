using System;

namespace Lista5_Q6
{
	public class Cubo : Figura3D
	{
		double lado;

		public Cubo (double lado)
		{
			this.lado = lado;
		}

		public override double Volume ()
		{
			return Math.Pow(lado,3);
		}


	}
}

