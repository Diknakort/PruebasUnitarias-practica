using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Figuras
{
    public class Triangulo : IFigura
    {
        private int lado1;
        private int lado2;
        private int lado3;

        public Triangulo(int lado1, int lado2, int lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public decimal dameArea()
        {
            double semiperimetro = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));
            return (decimal) area;
        }

        public decimal damePerimetro()
        {
            return lado1 + lado2 + lado3;
        }
    }
}
