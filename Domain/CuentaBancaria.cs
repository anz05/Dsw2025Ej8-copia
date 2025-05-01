using System.ComponentModel.DataAnnotations;

namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    //private TipoCuenta _tipo;
    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public Estado Estado { get; protected set; }
    //public decimal Comision { get; }
    //private decimal _limiteDeDescubierto;
    public string[] Titulares { get; }


    public CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        Numero = numero;
        Saldo = saldo;
        Estado = Estado.Activa;
        Titulares = titulares;
    }

    #region Getters/Setters

    #endregion
    public abstract void Depositar(decimal monto);

    protected void ValidarMonto(decimal monto)
    {
        if (monto <= 0) throw new MontoNoValido($"Cuenta {Numero}: El monto ingresado no es válido para la operación solicitada");
    }

    protected void ValidarCuenta()
    {
        if (Estado.Activa == 0) throw new CuentaNoActiva($"Cuenta {Numero}: No se puede operar con la cuenta {Estado}");
    }

    public abstract void Retirar(decimal monto);

}