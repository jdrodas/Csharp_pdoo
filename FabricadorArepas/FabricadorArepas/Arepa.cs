using System;

namespace FabricadorArepas
{
    abstract class Arepa
    {
        //los atributos
        protected int numeroMolino, diasCaducidad;

        public Arepa()
        {
            numeroMolino = 0;
            diasCaducidad = 0;
        }

        public Arepa(int diasCaducidad, int numeroMolino)
        {
            this.diasCaducidad = diasCaducidad;
            this.numeroMolino = numeroMolino;
        }

        //Propiedades para los atributos
        public int NumeroMolino
        {
            get { return numeroMolino; }
            set { numeroMolino = value; }
        }

        public int DiasCaducidad
        {
            get { return diasCaducidad; }
            set { diasCaducidad = value; }
        }

        public abstract string ObtieneInformacion();
    }
}
