using System;

namespace FabricadorArepas
{
    class ArepaAsada: Arepa, IAsable
    {
        //Los atributos
        private int temperaturaCoccion;

        public ArepaAsada() : base()
        {
            temperaturaCoccion = 0;
        }

        public ArepaAsada(int temperaturaCoccion,
            int diasCaducidad,
            int numeroMolino) : base(diasCaducidad, numeroMolino)
        {
            this.temperaturaCoccion = temperaturaCoccion;
        }

        //Propiedad del atributo
        public int TemperaturaCoccion
        {
            get { return temperaturaCoccion; }
            set { temperaturaCoccion = value; }
        }

        public string InfoCoccion()
        {
            string resultado = "Temperatura de cocción: " +
                temperaturaCoccion + Environment.NewLine;
            return resultado;
        }

        public override string ObtieneInformacion()
        {
            string resultado = "Esta arepa fue asada. " + Environment.NewLine +
                "La masa salió del molino " + numeroMolino + Environment.NewLine +
                "Tiene " + diasCaducidad + " dias de caducidad" + Environment.NewLine +
                InfoCoccion();
            return resultado;
        }
    }
}
