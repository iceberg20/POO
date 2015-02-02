using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fib
    {
        public int a1;
        public int a2;
        public int next;
        public int n;
        public Fib()
        {
            a1 = 1;
            a2 = 1;
            next = a1 + a2;
            n = 1;
        }

        public void Reiniciar()
        {
            a1 = 1;
            a2 = 1;
            next = a1 + a2;
        }

        public int Proximo()
        {
            int saida =1;

            if (n == 1 || n == 2)
            {
                next = 1;
                n++;
            }

            else
            {
                next = a1 + a2;
                a1 = a2;
                a2 = next;
            }
            return next;
        }
    }
}
