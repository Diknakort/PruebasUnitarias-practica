using FigurasNET.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Test.Figuras
{
    [TestClass]
    public class UnitTestFabricaFiguras02
    {
        FabricaFiguras02 fab = new();
        [TestMethod]
        public void DameFigura()
        {
            var figura = fab.dameFigura(TipoFigura.Cuadrado);
            Assert.IsInstanceOfType(figura, typeof(Cuadrado));
            Assert.AreEqual(64, figura.dameArea());
            Assert.AreEqual(32, figura.damePerimetro());
        }


    }
}
