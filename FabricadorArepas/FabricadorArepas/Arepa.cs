using System;

namespace FabricadorArepas
{
    abstract class Arepa
    {
        //Atributos
        protected string tipoDeMasa;
        protected int diasCaducidad, numeroMolino;

        //Constructor de la clase
        public Arepa()
        {
            tipoDeMasa = "";
            diasCaducidad = 0;
            numeroMolino = 0;
        }
        public Arepa(string tipoDeMasa, int diasCaducidad, int numeroMolino)
        {
            this.tipoDeMasa = tipoDeMasa;
            this.numeroMolino = numeroMolino;
            this.diasCaducidad = diasCaducidad;
        }
        public string TipoDeMasa
        {
            get { return tipoDeMasa; }
            set { tipoDeMasa = value; }
        }
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
