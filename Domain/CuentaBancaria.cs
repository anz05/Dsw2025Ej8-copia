namespace Dsw2025Ej8.Domain;

public class CuentaBancaria
{
    //private TipoCuenta _tipo;
    public string Numero { get; }
    protected decimal Saldo { get;  set; }
    public Estado Estado { get; set; }
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

    }

    public virtual void Retirar(decimal monto)
    {

    }

    public virtual void AplicarInteres()
    {

    }
}