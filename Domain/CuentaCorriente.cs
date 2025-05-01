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
        public decimal LimiteDeDescubierto { get; init; }

        public override void Depositar(decimal monto)
        {
            decimal montoFinal = monto - (monto * _comision);
            Saldo += montoFinal;
        }

        public override void Retirar(decimal monto)
        {
            if (Saldo - monto >= -_limiteDeDescubierto)
            {   
                Saldo -= monto;

                if (Saldo < 0)
                {
                   Estado= Estado.Suspendida;
                }
            }
        }
    }
}
