using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Figuras
{
    public interface IFiguraBuilder
    {
        IFigura dameFigura(TipoFigura tipoFigura);
    }
}
