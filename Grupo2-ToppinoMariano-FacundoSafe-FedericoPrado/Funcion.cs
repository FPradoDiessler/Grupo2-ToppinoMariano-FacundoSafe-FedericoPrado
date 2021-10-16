using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo2_ToppinoMariano_FacundoSafe_FedericoPrado
{
    class Funcion
    {
        private Pelicula pelicula;
        private List<Asiento> asientos;
        private List<Entrada> entradasDisponibles;
        private DateTime fecha;
        private double hora;
        private int sala;

        private const int SALA_MAX = 4;
        private const int SALA_MIN = 1;

        /// <summary>
        /// CONSTRUCTOR de la clase setea la cantidad de entradas disponibles
        /// </summary>
        /// <param name="pelicula"></param>
        /// <param name="fecha"></param>
        /// <param name="hora"></param>
        /// <param name="Sala"></param>
        public Funcion(Pelicula pelicula, DateTime fecha, double hora, int Sala)
        {
            this.entradasDisponibles = new List<Entrada>();
            this.asientos = new List<Asiento>();
            setPelicula (pelicula);
            setFecha (fecha);
            this.hora = hora;
            setSala (sala);
            setAsientos();
            setEntradasDisponibles();


        }



        /// <summary>
        /// Setea la pelicula solo para el caso que no sea Null
        /// </summary>
        /// <param name="pelicula"></param>
        private void setPelicula(Pelicula pelicula)
        {
            if (pelicula != null)
            {
                this.pelicula = pelicula;
            }
            else{
                throw new ArgumentNullException("*** Debe ser Una pelicula VALIDA ***");
            }
        }
        /// <summary>
        /// setea la fecha solo para el caso que no sea anterior a la fecha actual
        /// </summary>
        /// <param name="fecha"></param>
        private void setFecha (DateTime fecha)
            
        {
            DateTime fechaHoy = DateTime.Now;

            if (DateTime.Compare(fecha, fechaHoy) < 0){
               
                throw new ArgumentException("*** la Funcion Solicitada YA NO ESTA DISPONIBLE ***");


            }


            this.fecha = fecha;

        }


        

        /// <summary>
        /// setea las salas chequeando que no sea invalido el ingreso
        /// </summary>
        /// <param name="sala"></param>
        private void setSala (int sala)
        {
            if (sala < SALA_MIN || sala > SALA_MAX)
            {
                throw new ArgumentException("***la Sala solicitada NO EXISTE***");

            }else
            {
                this.sala = sala;
            }
        }



        /// <summary>
        /// completa los asientos en la lista asignandoles nombre y letra
        /// </summary>
        public void setAsientos()
        {
            char letra = 'a';
            
                
            for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 15; j++)
                {
                    Asiento asientoAgregar = new Asiento(letra, j);
                    asientos.Add(asientoAgregar);
                    
                }
                letra++;
                }
            
            }




        /// <summary>
        /// completa las entradas recorriendo los asientos existentes en el listado de asientos
        /// </summary>
        public void setEntradasDisponibles()
        {
            foreach (Asiento actual in asientos)
            {
                Entrada entradaAgregar = new Entrada(this, actual);
                entradasDisponibles.Add(entradaAgregar);
            }
        }



        /// <summary>
        /// Devuelve la pelicula que se proyecta en la funcion
        /// </summary>
        /// <returns></returns>
        public Pelicula obtenerPelicula()
        {
            return this.pelicula;
        }



        /// <summary>
        /// sirve para identificar la Funcion para la Busqueda
        /// </summary>
        /// <param name="sala"></param>
        /// <param name="hora"></param>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public bool mismaFuncion(int sala, double hora, DateTime fecha)
        {
            return this.sala.Equals(sala) && this.hora == hora && this.fecha.Equals(fecha);
        }


        public int getSala()
        {
            return this.sala;
        }
        
        
        public double getHora()
        {
            return this.hora;
        }

        public DateTime getfecha()
        {
            return this.fecha;
        }

    }


}

