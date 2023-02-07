using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    public class ArepaAsada : Arepa, IAsable
    {
        private int temperaturaCoccion;

        public ArepaAsada() : base()
        {
            temperaturaCoccion = 0;
        }

        public ArepaAsada(string tipoDeMasa, string tipoArepa,
            int diasCaducidad, int numeroMolino, int temperaturaCoccion)
        {
            this.tipoArepa = tipoArepa;
            this.tipoDeMasa= tipoDeMasa;
            this.diasCaducidad= diasCaducidad;
            this.numeroMolino= numeroMolino;
            this.temperaturaCoccion= temperaturaCoccion;
        }

        public int GetTemperaturaCoccion()
        {
            return temperaturaCoccion;
        }

        public void SetTemperaturaCoccion(int temperaturaCoccion)
        {
            if (temperaturaCoccion > 0)
                this.temperaturaCoccion = temperaturaCoccion;
            else
                this.temperaturaCoccion = 0;
        }

        public string InfoCoccion()
        {
            string info = $"Temperatura de cocción: {temperaturaCoccion}";
            return info;
        }

        public override string ObtieneInformacion()
        {
            string informacion = $"Esta es una arepa {tipoArepa}. \n" +
                $"La masa es de {tipoDeMasa} \n" +
                $"Salió del molino {numeroMolino} \n" +
                $"Días de caducidad: {diasCaducidad} \n" +
                InfoCoccion();
            return informacion;
        }
    }
}
