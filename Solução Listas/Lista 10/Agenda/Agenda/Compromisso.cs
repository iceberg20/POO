using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Compromisso
    {
        public string assunto;
        public string local;
        public Horario horario;

        public Compromisso()
        {

        }

        public Compromisso(string assunto, string local, Horario horario)
        {
            this.assunto = assunto;
            this.local = local;
            this.horario = horario;
        }

        public override string ToString()
        {
            return horario.ToString()+ " - " +assunto.ToString() + " " + local.ToString();
        }

        public string Assunto()
        {
            return assunto;
        }

        public string Horario()
        {
            return horario.ToString();
        }
    }

    public class Ag : List<Compromisso> 
    {
 
    }
}
