using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    class Asiento
    {

        private char fila;
        private int numero;

        public Asiento(char fila, int nro)
        {
            SetFila(fila);
            setNro(nro);
        }

        private void SetFila(char fila)
        {
            this.fila = ValidarFila(fila);
        }

        private string ValidarFila(char fila)
        {
            const int CANT_FILAS = 10;
            char[] filasPosibles = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            bool isValid = false;

            if(fila == "")
            {
                throw new ArgumentException("La fila no puede estar vacía").
            }

            for(char x: filasPosibles)
            {
                if(fila == x)
                {
                    isValid = true;
                }
            }

            if (!isValid)
            {
                throw new ArgumentException("Ingrese una fila válida (a - j)");
            }

            return fila;
        }
    
        private void SetNro(int nro)
        {
            this.numero = ValidarNro(nro);
        }

        private int ValidarNro(int nro)
        {
            if(nro <= 0 || nro > 15)
            {
                throw new ArgumentException("Ingrese un número válido (1-15)")
            }

            return nro;
        }
    }
}
