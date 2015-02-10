using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Horario
    {
        public int dia;
        public int mes;
        public int ano;
        public int hora;
        public int minuto;

        public Horario()
        { 
        }
        
        public Horario(int dia, int mes, int ano, int hora, int minuto)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
            this.hora = hora;
            this.minuto = minuto;
        }

        public override string ToString()
        {
            DateTime d = new DateTime(ano, mes, dia, hora, minuto,0);
            string min = "";
            if (minuto < 10) min = "0";

            return d.ToShortDateString() + " " + hora.ToString() +":"+min+minuto;
        }
    }
}
