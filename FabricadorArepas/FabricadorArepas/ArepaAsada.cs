namespace FabricadorArepas
{
    public class ArepaAsada:Arepa, IAsable
    {
        private int temperaturaCoccion;

        public ArepaAsada() : base()
        {
            temperaturaCoccion = 0;
        }

        public ArepaAsada(string tipoDeMasa,
                              int diasCaducidad,
                              int numeroMolino,
                              int temperaturaCoccion,
                              string tipoArepa)
        {
            this.tipoDeMasa = tipoDeMasa;
            this.diasCaducidad = diasCaducidad;
            this.numeroMolino = numeroMolino;
            this.temperaturaCoccion = temperaturaCoccion;
            this.tipoArepa = tipoArepa;
        }

        public int TemperaturaCoccion
        {
            get { return temperaturaCoccion; }
            set { temperaturaCoccion = value; }
        }

        public string InfoCoccion()
        {
            string info = $"Temperatura para cocción: {temperaturaCoccion}";
            return info; ;
        }

        public override string ObtieneInformacion()
        {
            string info = $"Esta arepa fue {tipoArepa}. \n" +
                $"La masa es de {tipoDeMasa} \n" +
                $"Salió del molino {numeroMolino} \n" +
                $"Dias caducidad: {diasCaducidad} \n" +
                InfoCoccion();
            return info;
        }
    }
}
