using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Fornecedor
    {
        public int id {set; get;}
        public string nome {set; get;}
       
        public Fornecedor()
        {
        }

        public override string ToString()
        {
            return nome;
        }
    }

    public class Fornecedores : List<Fornecedor>
    {
 
    }
}
