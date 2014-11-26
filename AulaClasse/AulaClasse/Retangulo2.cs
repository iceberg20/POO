using System;

namespace AulaClasse
{
	public class Retangulo2
	{
		private int _base;
		private int _altura;

		public Retangulo2 ()
		{

		}

		public Retangulo2 (int b, int a)
		{
			_base = b;
			_altura = a;
		}

		public void SetBase(int b)
		{
			_base = b;
		}

		public void SetAltura(int a)
		{
			_altura = a;
		}

		public int Area()
		{
			return _base * _altura;
		}

	}
}

