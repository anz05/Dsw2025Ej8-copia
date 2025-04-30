using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class CuentaCorriente : CuentaBancaria
    {
        private decimal _comision;
        private decimal _limiteDeDescubierto;

        public CuentaCorriente(string numero, decimal saldo, decimal comision, string[] titulares) : base(numero, saldo, titulares)
        {
            _comision = comision;
        }
        public decimal LimiteDeDescubierto
        {
            get => _limiteDeDescubierto;
            set => _limiteDeDescubierto = value;
        }

        public override void Depositar(decimal monto)
        {
            decimal montoFinal = monto - (monto * _comision);
            _saldo += montoFinal;
        }

        public override void Retirar(decimal monto)
        {
            if (_saldo - monto >= -_limiteDeDescubierto)
            {
                _saldo -= monto;

                if (_saldo < 0)
                {
                    SetEstado(Estado.Suspendida);
                }
            }
        }
    }
}
