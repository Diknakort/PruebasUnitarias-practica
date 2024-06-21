using FigurasNET.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasNET.Vehiculos;
using FigurasNET.Vehiculos.Factoria;
using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET.Test.Vehiculos
{
    
    [TestClass]
    public class UnitTestFabricaDeEnero
    {
      
        [TestMethod]
        public void vehiculoNuclearCompeticion()
        {
            var vehiculo = new Vehiculo(new MotorNuclear(78, 100), new RuedaCompeticion(1));
            Assert.IsInstanceOfType(vehiculo, typeof(Vehiculo));
            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaCompeticion));
            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorNuclear));
            Assert.AreEqual(7800, vehiculo.MotorDelVehiculo1.damePotencia());
            Assert.AreEqual(100, vehiculo.MotorDelVehiculo1.dameCoste());
        }

        [TestMethod]
        public void vehiculoEstandarCompeticion()
        {
            var vehiculo = new Vehiculo(new MotorEstandar(78, 100), new RuedaCompeticion(1));
            Assert.IsInstanceOfType(vehiculo, typeof(Vehiculo));
            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaCompeticion));
            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorEstandar));
            Assert.AreEqual(78, vehiculo.MotorDelVehiculo1.damePotencia());
            Assert.AreEqual(100, vehiculo.MotorDelVehiculo1.dameCoste());
        }
        [TestMethod]
        public void vehiculoEstandarNormal()
        {
            var vehiculo = new Vehiculo(new MotorEstandar(78, 100), new RuedaNormal("normal", 20));
            Assert.IsInstanceOfType(vehiculo, typeof(Vehiculo));
            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaNormal));
            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorEstandar));
            Assert.AreEqual(78, vehiculo.MotorDelVehiculo1.damePotencia());
            Assert.AreEqual(100, vehiculo.MotorDelVehiculo1.dameCoste());
        }
        [TestMethod]
        public void vehiculoNuclearNormal()
        {
            var vehiculo = new Vehiculo(new MotorNuclear(78, 100), new RuedaNormal("normal", 20));
            Assert.IsInstanceOfType(vehiculo, typeof(Vehiculo));
            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaNormal));
            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorNuclear));
            Assert.AreEqual(7800, vehiculo.MotorDelVehiculo1.damePotencia());
            Assert.AreEqual(100, vehiculo.MotorDelVehiculo1.dameCoste());
        }
    

        [TestMethod]
        public void dameCompeti()
        {

            FabricaDeEnero fab = new();
            var vehiculo = fab.dameVehiculo(TipoVehiculo.NuclearDeCompeticion);
            Assert.IsInstanceOfType(vehiculo, typeof(Vehiculo));
            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaCompeticion));
            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorNuclear));
            Assert.AreEqual("competicion", vehiculo.RuedasDelVehiculo1.dameGoma());
            Assert.AreEqual(22, vehiculo.RuedasDelVehiculo1.dameCoste());
            Assert.AreEqual(100, vehiculo.MotorDelVehiculo1.dameCoste());
            Assert.AreEqual(7800, vehiculo.MotorDelVehiculo1.damePotencia());
            
        }
        [TestMethod]
        public void dameNormal()
        {

            FabricaDeEnero fab = new();
            var vehiculo = fab.dameVehiculo(TipoVehiculo.Normal);
            Assert.IsInstanceOfType(vehiculo, typeof(Vehiculo));
            Assert.IsInstanceOfType(vehiculo.RuedasDelVehiculo1, typeof(RuedaNormal));
            Assert.IsInstanceOfType(vehiculo.MotorDelVehiculo1, typeof(MotorEstandar));
            Assert.AreEqual("normal", vehiculo.RuedasDelVehiculo1.dameGoma());
            Assert.AreEqual(89, vehiculo.RuedasDelVehiculo1.dameCoste());
            Assert.AreEqual(100, vehiculo.MotorDelVehiculo1.dameCoste());
            Assert.AreEqual(78, vehiculo.MotorDelVehiculo1.damePotencia());

        }

    }
}
