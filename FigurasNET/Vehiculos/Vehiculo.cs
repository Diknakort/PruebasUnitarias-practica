using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Vehiculos
{
    /// <summary>
    /// Clase por composición compuesta por un motor y unas ruedas
    /// </summary>
    public class Vehiculo
    {
        private IMotor MotorDelVehiculo;
        private IRueda RuedasDelVehiculo;

        public Vehiculo(IMotor motorDelVehiculo, IRueda ruedasDelVehiculo)
        {
            MotorDelVehiculo = motorDelVehiculo;
            RuedasDelVehiculo = ruedasDelVehiculo;
        }

        public IMotor MotorDelVehiculo1 { get => MotorDelVehiculo; set => MotorDelVehiculo = value; }
        public IRueda RuedasDelVehiculo1 { get => RuedasDelVehiculo; set => RuedasDelVehiculo = value; }
    }
}
