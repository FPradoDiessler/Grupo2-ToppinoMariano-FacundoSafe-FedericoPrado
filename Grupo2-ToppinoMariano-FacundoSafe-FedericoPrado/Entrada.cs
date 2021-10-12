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
            set { if(this.funcion == null) { this.funcion = value; } }
        }
    }
}
