using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Figuras;

namespace FigurasNET.Test.Figuras
{
    [TestClass]
    public class UnitTestRectangulo
    {
        Rectangulo miRectangulo = new Rectangulo(8, 10);
        [TestMethod]
        public void Area()
        {
            Assert.AreEqual(80, miRectangulo.dameArea());
        }
        [TestMethod]

        public void Perimetro()
        {
            Assert.AreEqual(36, miRectangulo.damePerimetro());
        }
    }
}
