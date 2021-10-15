using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    class Debito:Tarjeta
    {

        public Debito(int numero, DateTime fechaDeVencimiento, int codigoSeguridad, string nombre):base (numero, fechaDeVencimiento, codigoSeguridad, nombre)
        {

        }
        

        public override Boolean realizarPago()
        {
            return true;
        }
    }
}
