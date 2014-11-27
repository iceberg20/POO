using System;

namespace Lista4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PA pa = new PA();
			pa.SetPrimeiro(2);
			pa.SetRazao(2);
			double[] x = pa.GetElementos(10);
			foreach (double elem in x) {
				Console.WriteLine(elem);
				Console.WriteLine (pa.GetSoma (10));
			}
			Console.ReadKey();
		}
	}
}
