using FigurasNET.Figuras;

namespace FigurasNET.Test
{
    [TestClass]
    public class UnitTestFabricaDeFiguras01
    {
        FabricaDeFiguras01 fab  = new ();
        [TestMethod]
        public void dameCuadrado()
        {
            var figura = fab.dameFigura(TipoFigura.Cuadrado);
            Assert.IsInstanceOfType(figura, typeof(Cuadrado));
            Assert.AreEqual(4, figura.dameArea());
            Assert.AreEqual(8, figura.damePerimetro());

        }


    }
}