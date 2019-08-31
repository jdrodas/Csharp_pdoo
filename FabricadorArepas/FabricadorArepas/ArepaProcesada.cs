using System;

namespace FabricadorArepas
{
    class ArepaProcesada : Arepa, IAsable, ICongelable
    {
        //Los atributos
        private int diasMaximosCongelado, temperaturaCoccion;

        public ArepaProcesada() : base()
        {
            diasMaximosCongelado = 0;
            temperaturaCoccion = 0;
        }

        public ArepaProcesada(int diasMaximosCongelado,
                              int temperaturaCoccion,
                              int numeroMolino,
                              int diasCaducidad) : base(diasCaducidad, numeroMolino)
        {
            this.diasMaximosCongelado = diasMaximosCongelado;
            this.temperaturaCoccion = temperaturaCoccion;
        }

        public int DiasMaximosCongelado
        {
            get { return diasMaximosCongelado; }
            set { diasMaximosCongelado = value; }
        }

        public int TemperaturaCoccion
        {
            get { return temperaturaCoccion; }
            set { temperaturaCoccion = value; }
        }

        public string InfoCoccion()
        {
            string resultado = "Temperatura de cocción en proceso: " +
                temperaturaCoccion + Environment.NewLine;
            return resultado;
        }

        public string InfoCongelacion()
        {
            string resultado = "Dias máximos de congelación en proceso: " +
                diasMaximosCongelado + Environment.NewLine;
            return resultado;
        }

        public override string ObtieneInformacion()
        {
            string resultado = "Esta arepa fue Procesada. " + Environment.NewLine +
                "La masa salió del molino " + numeroMolino + Environment.NewLine +
                "Tiene " + diasCaducidad + " dias de caducidad" + Environment.NewLine +
                InfoCongelacion() + InfoCoccion();
            return resultado;
        }

    }
}
