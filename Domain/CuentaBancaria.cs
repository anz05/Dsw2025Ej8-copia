namespace Dsw2025Ej8.Domain;

public class CuentaBancaria
{
    //private TipoCuenta _tipo;
    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public Estado Estado { get; protected set; }
    public decimal Comision { get; }
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
    public virtual void Depositar(decimal monto)
    {
        if (monto <= 0) throw new MontoNoValido("El monto ingresado no es válido para la operación solicitada");
        if (Estado.Activa == 0) throw new CuentaNoActiva($"No se puede operar con la cuenta {Estado}");
    }

    public virtual void Retirar(decimal monto)
    {
        if (monto <= 0) throw new MontoNoValido("El monto ingresado no es válido para la operación solicitada");
        if (Estado.Activa == 0) throw new CuentaNoActiva($"No se puede operar con la cuenta {Estado}");
        if (Saldo < monto) throw new SaldoInsuficiente("La cuenta no cuenta con saldo suficiente para la operacion. Fue suspendida");

    }

    public virtual void AplicarInteres()
    {

    }
}