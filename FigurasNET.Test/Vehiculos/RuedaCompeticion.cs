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
    public class UnitTestRuedaCompeticion
    {
        Vehiculo miRueda = new Vehiculo(new MotorNuclear(78, 100), new RuedaCompeticion(5));

        [TestMethod]
 
        public void dameCoste()
        {
            Assert.AreEqual(110, miRueda.RuedasDelVehiculo1.dameCoste());

        }
        [TestMethod]

        public void dameGoma()
        {
            Assert.AreEqual("competicion", miRueda.RuedasDelVehiculo1.dameGoma());
        }
    }
}
