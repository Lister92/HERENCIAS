using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class Triangulo : Poligono
    {
        int lado1;
        int lado2;
        int lado3;
        public int Lado1 { get => lado1; set => lado1 = value; }
        public int Lado2 { get => lado2; set => lado2 = value; }
        public int Lado3 { get => lado3; set => lado3 = value; }
        public Triangulo(int lado1, int lado2, int lado3) : base(3)

        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }

        public override double AreaTriste()
        {
            double result = 0;
            result = (Lado1 + Lado2 + Lado3) / 2;
            result = Math.Sqrt(result * (result - Lado1) * (result - Lado2) * (result - Lado3));
            return result;
        }
    }
}
