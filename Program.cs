using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldoInteres; 
            CuentaBancaria[] cuentas = new CuentaBancaria[4];
            
            try
            {
                var cuenta = new CajaDeAhorro("1", 20000, new string[] { "Ana", "Laura" })
                {
                    TasaDeInteres = 0.04m,
                };
                cuenta.Depositar(1000.00m);
                cuenta.Retirar(4000m);
                cuentas[0] = cuenta;

            }
            catch (Exception ex)
            {
                ControladorExcepciones.Handle(ex);
            }

            try
            {
                var cuenta = new CajaDeAhorro("2", 5000, new string[] { "Maria", "Perez" })
                {
                    TasaDeInteres = 0.04m,
                };
                cuenta.Depositar(-980m);
                cuenta.Retirar(4000m);
                cuentas[1] = cuenta;

            }
            catch (Exception ex)
            {
                ControladorExcepciones.Handle(ex);
            }

            try
            {
                var cuenta = new CuentaCorriente("3", 10000, new string[] { "Juan", "Lopez" })
                {
                    Comision = 0.4m,
                    LimiteDeDescubierto = 2000m,
                };
                cuenta.Depositar(-980m);
                cuenta.Retirar(-4000m);
                cuentas[2] = cuenta;

            }
            catch (Exception ex)
            {
                ControladorExcepciones.Handle(ex);
            }

            try
            {
                var cuenta = new CuentaCorriente("4", 3000, new string[] { "Pedro", "Araoz" })
                {
                    Comision = 0.5m,
                    LimiteDeDescubierto = 2000m,
                };
                cuenta.Depositar(1000m);
                cuenta.Retirar(4500m);
                cuentas[3] = cuenta;

            }
            catch (Exception ex)
            {
                ControladorExcepciones.Handle(ex);
            }
            Console.WriteLine("\n");
            Console.WriteLine("***** RESUMEN CUENTAS SIN EXCEPCIONES *****");
            foreach (var cuenta in cuentas)
            {
                if (cuenta != null)
                {
                    Console.WriteLine("\n");

                    var Mostrar = new { cuenta.Numero, Tipo = cuenta.GetType().Name, cuenta.Saldo };
                    Console.WriteLine(Mostrar);

                    if (cuenta is CajaDeAhorro cuentaDeAhorro)
                    {
                        saldoInteres = cuentaDeAhorro.AplicarInteres();
                        Console.WriteLine($"El saldo de cuenta {cuentaDeAhorro.Numero} aplicando el interes es: {saldoInteres}");
                    }
                } 
            }
        }
    }
}
