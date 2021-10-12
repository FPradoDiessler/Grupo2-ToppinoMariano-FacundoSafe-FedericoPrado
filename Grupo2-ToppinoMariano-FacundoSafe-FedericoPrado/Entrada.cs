using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    class Entrada
    {

        private Funcion funcion;
        private Asiento asiento;

        public Entrada(Funcion f, Asiento a)
        {
            this.funcion = f;
            this.asiento = a;
        }

        public Funcion Funcion
        {
            get { return funcion};
            set { SetAtt(this.funcion, value)}
        }

        public Asiento Asiento
        {
            get { return asiento };
            set { SetAtt(this.asiento, value)}
        }

        /// <summary>
        /// si x es null, se asigna y a x.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void SetAtt(var x, var y)
        {
            if(x == null)
            {
                x = y;
            }
        }
    }
}
