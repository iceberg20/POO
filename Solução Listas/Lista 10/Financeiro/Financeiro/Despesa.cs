using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Despesa
    {
        public int id {set;get;}
        public int idFornecedor { set; get; }
        public DateTime data { set; get; }
        public double valor { set; get; }

        public Despesa()
        {
 
        }
        
        public override string ToString()
        {
            return id.ToString();
        }
    }

    public class Despesas : List<Despesa>
    {

    }
}
