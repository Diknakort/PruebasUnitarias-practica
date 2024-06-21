using FigurasNET.Figuras;

namespace FigurasNET.Test
{
    [TestClass]
    public class UnitTestCuadrado
    {
        Cuadrado miCuadrado = new Cuadrado(8);
        [TestMethod]
        public void Area()
        {
            Assert.AreEqual(64, miCuadrado.dameArea());
        }

        [TestMethod]
        public void Perimetro()
        {
            Assert.AreEqual(32, miCuadrado.damePerimetro());
        }
    }
}