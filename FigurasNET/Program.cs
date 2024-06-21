using FigurasNET.Figuras;
using FigurasNET.Vehiculos;
using FigurasNET.Vehiculos.Factoria;
using FigurasNET.Vehiculos.Motores;
using FigurasNET.Vehiculos.Ruedas;

namespace FigurasNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IFiguraBuilder Fabrica = new FabricaDeFiguras01();
            
            IFigura Cuadrado10 = Fabrica.dameFigura(TipoFigura.Cuadrado);
            IFigura Triangulo = Fabrica.dameFigura(TipoFigura.Triangulo);

            IMotor Motor_ = new MotorNuclear(89, 100);
            IRueda RuedasMercedes = new RuedaNormal("normal", 100);
            IRueda Ruedas2 = new RuedaCompeticion(1.10);
            Vehiculo miMercedes = new Vehiculo(Motor_, Ruedas2);

            IFactoriaVehiculos FabricaVeh = new FabricaDeEnero();
            Vehiculo miSuper = FabricaVeh.dameVehiculo(TipoVehiculo.NuclearDeCompeticion);



        }
    }
}