using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    class ArepaAsada:Arepa, IAsable
    {
        private int temperaturaCoccion;

        public ArepaAsada() : base()
        {
            temperaturaCoccion = 0;
        }

        public ArepaAsada(string tipoDeMasa,
                              int diasCaducidad,
                              int numeroMolino,
                              int temperaturaCoccion)
        {
            this.tipoDeMasa = tipoDeMasa;
            this.diasCaducidad = diasCaducidad;
            this.numeroMolino = numeroMolino;
            this.temperaturaCoccion = temperaturaCoccion;
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
            string info = "Esta arepa fue asada. \n" +
                $"La masa es de {tipoDeMasa} \n" +
                $"Salió del molino {numeroMolino} \n" +
                $"Dias caducidad: {diasCaducidad}" +
                InfoCoccion();
            return info;
        }
    }
}
