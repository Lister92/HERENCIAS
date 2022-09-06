using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class Rectangulo : Poligono
    {
        int lado1;
        int lado2;

        public Rectangulo(int lado1, int lado2) : base(4)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        public override double AreaTriste()
        {            
            double result = 0;
            result = lado1 * lado2;
            return result;
        }        
    }
}
