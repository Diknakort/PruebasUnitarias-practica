using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Figuras
{
    public class FabricaDeFiguras01 : IFiguraBuilder
    {
        public IFigura dameFigura(TipoFigura tipoFigura)
        {
           switch(tipoFigura) 
            {
                case TipoFigura.Cuadrado: return new Cuadrado(2);
                case TipoFigura.Rectangulo: return new Rectangulo(2, 6);
                case TipoFigura.Triangulo: return new Triangulo(2, 4, 6);
                default: return null;
            }
        }
    }
}
