using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Compromisso
    {
        private string assunto;
        private string local;
        private Horario horario;

        public Compromisso(string assunto, string local, Horario horario)
        {
            this.assunto = assunto;
            this.local = local;
            this.horario = horario;
        }
    }

    class Ag : List<Compromisso> 
    {
 
    }
}
