using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    class Cliente
    {

        private string nombre;
        private string apellido;
        private string email;
        private string pass;
        private List<Entrada> entradas;
        private List<MedioDePago> mediosDePago;

        public Cliente(string nombre, string apellido, string email, string pass)
        {
            this.entradas = new List<>();
            SetMediosDePago();
            SetNombre(nombre);
            SetApellido(apellido);
            SetEmail(email);
            SetPassword(pass);
        }

        private void SetNombre(string nombre)
        {
            this.nombre = validarApenom(nombre);
        }

        private void SetApellido(string apellido)
        {
            this.apellido = validarApenom(apellido);
        }

        private void SetEmail(string email)
        {
            this.email = ValidarEmail(email);
        }

        private void SetPassword(string pass)
        {
            this.pass = ValidarPass(pass);
        }

        /// <summary>
        /// instancia mediosdepago y agrega un Efectivo por default
        /// </summary>
        private void SetMediosDePago()
        {
            this.mediosDePago = new List<>();

            this.mediosDePago.Add(new Efectivo());
        }

        /// <summary>
        /// me falta este
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private string ValidarEmail(string email)
        {
            //me falta la lógica

            return email;
        }

        private string ValidarPass(string pass)
        {
            char[] vPass = pass.ToCharArray();

            if (!ValidarLargoPass(vPass))
            {
                throw new ArgumentException("El largo de la contrasenia debe ser de 8 o más caracteres.");
            }
            if (!ValidarPassTieneMay(vPass))
            {
                throw new ArgumentException("Debe contener al menos 1 mayúscula.")
            }

            return pass;
        }

        /// <summary>
        /// devuelve true si al menos un elemento del char[] esta en mayusculas.
        /// </summary>
        /// <param name="vPass"></param>
        /// <returns></returns>
        private Boolean ValidarPassTieneMay(char[] vPass)
        {
            bool res = false;
            int i = 0;

            while(i < vPass.Length && !res)
            {
                if (Char.IsUpper(vPass[i)){
                    res = true;
                }

                i++;
            }

            return res;
        }

        /// <summary>
        /// devuelve true si es de 8 o mas
        /// </summary>
        /// <param name="vPass"></param>
        /// <returns></returns>
        private bool ValidarLargoPass(char[] vPass)
        {
            const int LARGO_MIN = 8;

            return vPass.Length >= LARGO_MIN;
        }

        /// <summary>
        /// throws argument exception si el parametro contiene numeros o esta vacio
        /// </summary>
        /// <param name="n">texto</param>
        /// <returns></returns>
        private string ValidarApenom(string n)
        {
            char[] str = n.ToCharArray();
            int i = 0;
            
            if(!string.IsNullOrEmpty(n))
            {
                while (i < str.Length)
                {
                    if (Char.IsDigit(str[i]))
                    {
                        throw new ArgumentException("No puede contener números.");
                    }
                }
            }
            else
            {
                throw new ArgumentException("No puede estar vacío");
            }

            return n;
        }

        public bool MismoMail(string str)
        {
            return this.nombre.Equals(str);
        }

        /// <summary>
        /// busca tarjeta segun el nro pasado por parametro. devuelve el objeto o null si no la encuentra
        /// </summary>
        /// <param name="nroTarjeta"></param>
        /// <returns></returns>
        private MedioDePago BuscarTarjeta(int nroTarjeta)
        {
            MedioDePago m = null;
            int i = 0;

            while (i < this.mediosDePago.Count && m == null){

                m = this.mediosDePago[i];

                if(m is Tarjeta)
                {
                    if (!m.nroTarjetaCoincide(nroTarjeta))
                    {
                        i++;
                        m = null;
                    }
                }
                else
                {
                    i++;
                    m = null;
                }
              
            }

            return m;
        }

        public bool AgregarMedioDePago(string nombre, int nroTarjeta, int fecVen, int codigo)
        {
            MedioDePago m = buscarTarjeta(nroTarjeta);
            bool resultado = false;

            if(m == null)
            {
                this.mediosDePago.Add(new MedioDePago(nombre, nroTarjeta, fecVen, codigo));
                resultado = true;
            }

            return resultado;
        }
        
        public void AgregarEntrada(Entrada e)
        {
            this.entradas.Add(e);
        }

        public void AgregarEntrada(Entrada e, int cant)
        {
            for(int i = 0; i < cant; i++)
            {
                this.entradas.Add(e);
            }
        }
    
        public bool RealizarPago()
        {
            bool res = false;

            if(this.entradas.Count > 0)
            {
                res = true;
            }

            return true;
        }
    }
}
