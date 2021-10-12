using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    class Credito:Tarjeta
    {
        private int cantidadCuotas;

        public Credito(int numero, DateTime fechaDeVencimiento, int codigoSeguridad, string nombre, int cantidadCuotas) : base(numero, fechaDeVencimiento, codigoSeguridad, nombre)
        {
            setCantidadCuotas(cantidadCuotas);
        }


        public override Boolean realizarPago()
        {
            return true;
        }


        private void setCantidadCuotas(int cantidadCuotas)
        {
            if (cantidadCuotas < 0)
            {
                throw new ArgumentException("No puede ser un numero negativo");
            }
            this.cantidadCuotas = cantidadCuotas;

        }
    }

       
}
