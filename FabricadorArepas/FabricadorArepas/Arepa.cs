namespace FabricadorArepas
{
    public abstract class Arepa
    {
        //Atributos
        protected string tipoDeMasa, tipoArepa;
        protected int diasCaducidad, numeroMolino;

        //Constructor de la clase
        public Arepa()
        {
            tipoDeMasa = "";
            tipoArepa = "";
            diasCaducidad = 0;
            numeroMolino = 0;
        }
        public Arepa(string tipoDeMasa, int diasCaducidad, int numeroMolino, string tipoArepa)
        {
            this.tipoDeMasa = tipoDeMasa;
            this.numeroMolino = numeroMolino;
            this.diasCaducidad = diasCaducidad;
            this.tipoArepa = tipoArepa;
        }
        public string TipoDeMasa
        {
            get { return tipoDeMasa; }
            set { tipoDeMasa = value; }
        }

        public string TipoArepa
        {
            get { return tipoArepa; }
            set { tipoArepa = value; }
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
