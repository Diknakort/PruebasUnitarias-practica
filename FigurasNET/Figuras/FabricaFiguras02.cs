using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Figuras
{
    public class FabricaFiguras02 : IFiguraBuilder
    {
        public IFigura dameFigura(TipoFigura tipoFigura)
        {
            return new Cuadrado(8);
        }
    }
}
