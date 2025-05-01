using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;
/*- Las excepciones deben incluir los siguiente mensajes:
- MontoNoValido -> El monto ingresado no es válido para la operación solicitada
- CuentaNoActiva -> No se puede operar con la cuenta {estado} (reemplazar por el estado en el que se encuentra)
- SaldoInsuficiente -> La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.
- La aplicación no debe interrumpir su funcionamiento si se produce una excepción.
 */
public static class ControladorExcepciones
{
    public static void Handle(Exception ex)
    {
        switch (ex)
        {
            case MontoNoValido mo:
                Console.WriteLine(mo.Message);
                break;
            case CuentaNoActiva cu:
                Console.WriteLine(cu.Message);
                break;
            case SaldoInsuficiente sa:
                Console.WriteLine(sa.Message);
                break;
            default:
                Console.WriteLine($"[ERROR DESCONOCIDO] {ex.Message}");
                break;
        }
    }


}
public class MontoNoValido : Exception
{
    public MontoNoValido(string message) : base(message) { }
}

public class CuentaNoActiva : Exception
{
    public CuentaNoActiva(string message) : base(message) { }
}

public class SaldoInsuficiente : Exception
{
    public SaldoInsuficiente(string message) : base(message) { }
}