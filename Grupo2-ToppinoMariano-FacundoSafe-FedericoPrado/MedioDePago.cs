using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    public abstract class MedioDePago
    {

        /// <summary>
        /// este metodo deberia indicar si se realizo el pago en caso de ser tarjetas como no manejamos con un banco para validarlo decidimos que devuelve siempre true;
        /// </summary>
        /// <returns></returns>
        public abstract Boolean realizarPago();
    }
}
