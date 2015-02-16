using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    public class Usuario
    {
        public string tipo{set;get;}
        public string login{set;get;}
        public string senha { set; get; }
    }

    public class Usuarios : List<Usuario>
    {
 
    }

}
