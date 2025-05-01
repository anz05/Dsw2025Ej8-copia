using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var cuenta1 = new CajaDeAhorro("1234", 1000, new string[] { "Ana", "Laura" })
                {
                    TasaDeInteres = 0.04m,
                };
                cuenta1.Depositar(1000.00m);
                cuenta1.Retirar(4000m);

                var myClaseAnonima = new { Numero = cuenta1.Numero, Tipo = cuenta1.GetType().Name, Saldo = cuenta1.Saldo };
                Console.WriteLine(myClaseAnonima);

            }
            catch (Exception ex)
            {
                ControladorExcepciones.Handle(ex);
            }

            try
            {
                var cuenta2 = new CajaDeAhorro("1235", 5000, new string[] { "Maria", "Perez" })
                {
                    TasaDeInteres = 0.04m,
                };
                cuenta2.Depositar(-980m);
                cuenta2.Retirar(4000m);

                var myClaseAnonima1 = new { Numero = cuenta2.Numero, Tipo = cuenta2.GetType().Name, Saldo = cuenta2.Saldo };
                Console.WriteLine(myClaseAnonima1);
            }
            catch (Exception ex)
            {
                ControladorExcepciones.Handle(ex);
            }
        }
    }
}
