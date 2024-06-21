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
    public class UnitTestMotorNuclear

    {
        Vehiculo miVehiculo = new Vehiculo(new MotorNuclear(78, 100), new RuedaCompeticion(1));

        [TestMethod]
        public void potencia()
        {
            Assert.AreEqual(7800, miVehiculo.MotorDelVehiculo1.damePotencia());

        }

        [TestMethod]
        public void dameCoste()
        {
            Assert.AreEqual(100, miVehiculo.MotorDelVehiculo1.dameCoste());

        }
    }
}
