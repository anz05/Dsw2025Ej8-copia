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
        _saldo += monto;
    }

    public override void Retirar(decimal monto)
    {
        _saldo -= monto;
    }

    public override void AplicarInteres()
    {
        _saldo += _saldo * _tasaDeInteres;
    }

}
