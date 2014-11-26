using System;

namespace Lista5_Q6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Esfera f = new Esfera (5);
			Cubo c = new Cubo (3);
			Cone o = new Cone (4,12);

			Console.WriteLine ("Volume da esfera = {0:f1} ",f.Volume());
			Console.WriteLine ("Volume do cubo = {0:f1} ",c.Volume());
			Console.WriteLine ("Volume do cubo = {0:f1} ",o.Volume());

		}
	}
}
