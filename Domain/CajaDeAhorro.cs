using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

class CajaDeAhorro : CuentaBancaria
{

    private decimal _tasaDeInteres;

    public decimal TasaDeInteres
    {
        get => _tasaDeInteres;
        set => _tasaDeInteres = value;
    }

    public CajaDeAhorro(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares)
    {

    }


    public override void Depositar(decimal monto)
    {
        if (monto <= 0) throw new MontoNoValido("El monto ingresado no es válido para la operación solicitada");
        if (Estado.Activa == 0) throw new CuentaNoActiva($"No se puede operar con la cuenta {Estado}");
        Saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        if (monto <= 0) throw new MontoNoValido("El monto ingresado no es válido para la operación solicitada");
        if (Estado.Activa == 0) throw new CuentaNoActiva($"No se puede operar con la cuenta {Estado}");
        if (Saldo < monto)
        {
            Estado = Estado.Suspendida;
            throw new SaldoInsuficiente("La cuenta no cuenta con saldo suficiente para la operacion. Fue suspendida");
        }
        
        Saldo -= monto;
    }

    public override void AplicarInteres()
    {
        if (Estado.Activa == 0) throw new CuentaNoActiva($"No se puede operar con la cuenta {Estado}");
        Saldo += Saldo * _tasaDeInteres;
    }

}
