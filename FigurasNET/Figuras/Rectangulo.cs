using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Figuras
{
    public class Rectangulo : IFigura
    {
        private int lado1;
        private int lado2;

        public Rectangulo(int lado1, int lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public decimal dameArea()
        {
            return lado1 * lado2;
        }

        public decimal damePerimetro()
        {
            return (lado1*2) + (lado2*2);
        }
    }
}
