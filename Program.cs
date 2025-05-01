using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lista = ["Juan", "Carlos", "Perez"];
            CajaDeAhorro cuenta;
            cuenta = new CajaDeAhorro("1", 1000m, lista);
            cuenta.TasaDeInteres = 0.05m;
            cuenta.Depositar(1000.00m);
            cuenta.Retirar(120m);

            var cuenta1 = new CuentaBancaria("", 1000, new string[] { "Ana", "Laura" })
            {
                TasaDeInteres = 0.04m,
            };

            var myClaseAnonima = new { Numero = cuenta.GetNumero(), Tipo = cuenta.GetType().Name, Saldo = cuenta.GetSaldo() };
            Console.WriteLine(myClaseAnonima);

            /*cuenta = new CajaDeAhorro("2", 10000m, ["Ana", "Rodriguez"]);
            cuenta.TasaDeInteres = 0.03m;
            cuenta.Depositar(1500m);
            cuenta.Retirar(5000m);

            var myClaseAnonima1 = new { Numero = cuenta.GetNumero(), Tipo = cuenta.GetType().Name, Saldo = cuenta.GetSaldo() };
            Console.WriteLine(myClaseAnonima1);*/
        }
    }
}
