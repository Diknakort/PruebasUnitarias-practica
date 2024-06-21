using FigurasNET.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Figuras
{
    public class Cuadrado : IFigura
    {
        public int lado;

        public Cuadrado(int lado)
        {
            this.lado = lado;
        }

        public decimal dameArea()
        {
            return lado * lado;
        }

        public decimal damePerimetro()
        {
            return lado * 4;
        }
    }
}
