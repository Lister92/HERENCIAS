using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class Poligono : Forma2D
    {       
        int numLado;

        public Poligono(int numLado)
        {
            this.numLado = numLado;
        }

        public int NumLado 
        { 
            get; set; 
        }

        public override double AreaTriste()
        {            
            double result = 0;
            return result;
        }
    }
}
