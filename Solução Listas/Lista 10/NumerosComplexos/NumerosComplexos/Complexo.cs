using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosComplexos
{
    public class Complexo
    {
        private double real;
        private double imag;

        public Complexo()
        {

        }

        public Complexo(double real, double imag)  
        {
          this.real = real;
          this.imag = imag;
        }

        public double Real
        {
            set { real = value; }
            get { return real;  }
        }

        public double Imag
        {
            set { imag = value; }
            get { return imag;  }
        }

        public static Complexo operator +(Complexo c1, Complexo c2) 
        {
            return new Complexo(c1.Real + c2.Real, c1.Imag + c2.Imag);
        }

        public static Complexo operator -(Complexo c1, Complexo c2)
        {
            return new Complexo(c1.Real - c2.Real, c1.Imag - c2.Imag);
        }

        public static Complexo operator /(Complexo c1, Complexo c2)
        {
            double r = (c1.real * c2.real + c1.imag * c2.imag) / (c2.real * c2.real + c2.imag * c2.imag);
            double i = (c2.real * c1.imag - c1.real * c2.imag) / (c2.real * c2.real + c2.imag * c2.imag);

            return new Complexo(r,i);
        }

        public static Complexo operator *(Complexo c1, Complexo c2)
        {
            double r = (c1.real * c2.real + c1.imag * c2.imag) / (c2.real * c2.real + c2.imag * c2.imag);
            double i = (c2.real * c1.imag - c1.real * c2.imag) / (c2.real * c2.real + c2.imag * c2.imag);

            return new Complexo(r, i);
        }

        
        public override string ToString()
       {
         return (System.String.Format("{0} + {1}i", real, imag));
       }



    }
}
