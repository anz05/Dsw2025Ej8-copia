using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

class CajaDeAhorro : CuentaBancaria
{
    public decimal TasaDeInteres {get; init;}

    public CajaDeAhorro(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares)
    {

    }


    public override void Depositar(decimal monto)
    {
        ValidarCuenta();
        ValidarMonto(monto);
        Saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        ValidarCuenta();
        ValidarMonto(monto);
        if (Saldo < monto)
        {
            Estado = Estado.Suspendida;
            throw new SaldoInsuficiente("La cuenta no cuenta con saldo suficiente para la operacion. Fue suspendida");
        }
        
        Saldo -= monto;
    }

    public void AplicarInteres()
    {
        ValidarCuenta();
        Saldo += Saldo * TasaDeInteres;
    }

}
