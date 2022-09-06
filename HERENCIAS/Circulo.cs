using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class Circulo : Forma2D
    {       
        double radio;
        public double Radio { get => radio; set => radio = value; }
        public Circulo(double radio)
        {
            this.Radio = radio;
        }       

        public override double AreaTriste()
        {
            double result = 0;
            result = Math.PI * Math.Pow(radio, 2);
            return result;
        }
    }
}
