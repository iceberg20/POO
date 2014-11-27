using System;

namespace Lista5
{
	public class Compromisso
	{
		private string assunto;
		private  DateTime data;
		private string local;

		public Compromisso (string assunto, DateTime data, string local)
		{
			this.assunto = assunto;
			this.data = data;
			this.local = local;
		}

		public override string ToString ()
		{
			string s = assunto + " " + local + " " + data.ToShortDateString();
			return s;
		}
	}
}

