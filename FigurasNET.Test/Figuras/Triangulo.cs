using FigurasNET.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Test.Figuras
{
    [TestClass]
    public class UnitTestTriangulo
    {
        Triangulo miTriangulo = new Triangulo(8, 10, 6);
        [TestMethod]
        public void Area()
        {
            Assert.AreEqual(24, miTriangulo.dameArea());
        }
        [TestMethod]

        public void Perimetro()
        {
            Assert.AreEqual(24, miTriangulo.damePerimetro());
        }
    }
}
