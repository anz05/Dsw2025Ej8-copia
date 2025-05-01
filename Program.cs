using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria[] cuentas;
            
            try
            {
                var cuenta = new CajaDeAhorro("1234", 1000, new string[] { "Ana", "Laura" })
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
                var cuenta = new CajaDeAhorro("1235", 5000, new string[] { "Maria", "Perez" })
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
                var cuenta = new CuentaCorriente("1236", 10000, new string[] { "Juan", "Lopez" })
                {
                    Comision = 5890m,
                    LimiteDeDescubierto = 2000m,
                };
                cuenta.Depositar(-980m);
                cuenta.Retirar(4000m);
                cuentas[2] = cuenta;

            }
            catch (Exception ex)
            {
                ControladorExcepciones.Handle(ex);
            }

            try
            {
                var cuenta = new CuentaCorriente("1237", 98333, new string[] { "Pedro", "Araoz" })
                {
                    Comision = 5890m,
                    LimiteDeDescubierto = 2000m,
                };
                cuenta.Depositar(-980m);
                cuenta.Retirar(4000m);
                cuentas[3] = cuenta;

            }
            catch (Exception ex)
            {
                ControladorExcepciones.Handle(ex);
            }

            foreach (var cuenta in cuentas)
            {
                var myClaseAnonima = new { Numero = cuenta.Numero, Tipo = cuenta.GetType().Name, Saldo = cuenta.Saldo };
                Console.WriteLine(myClaseAnonima);
            }
            
        }
    }
}
