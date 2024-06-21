using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;
using FigurasNET.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Test.Vehiculos
{
    [TestClass]
    public class UnitTestRuedaNormal

    {
        Vehiculo miVehiculo = new Vehiculo(new MotorNuclear(78, 100), new RuedaNormal("normal", 20));

        [TestMethod]
        public void potencia()
        {
            Assert.AreEqual("normal", miVehiculo.RuedasDelVehiculo1.dameGoma());

        }

        [TestMethod]
        public void dameCoste()
        {
            Assert.AreEqual(20, miVehiculo.RuedasDelVehiculo1.dameCoste());

        }
    }
}
