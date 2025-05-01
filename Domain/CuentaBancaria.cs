namespace Dsw2025Ej8.Domain;

public class CuentaBancaria
{
    //private TipoCuenta _tipo;
    protected string _numero;
    protected decimal _saldo;
    protected Estado _estado;
    //private decimal _limiteDeDescubierto;
    //private decimal _comision;
    protected string[] _titulares;

    public CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        _numero = numero;
        _saldo = saldo;
        _estado = Estado.Activa;
        _titulares = titulares;
    }

    #region Getters/Setters
    public string GetNumero()
    {
        return _numero;
    }

    public decimal GetSaldo()
    {
        return _saldo;
    }

    public Estado GetEstado()
    {
        return _estado;
    }

    public void SetEstado(Estado estado)
    {
        _estado = estado;
    }

    public string[] GetTitulares()
    {
        return _titulares;
    }
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