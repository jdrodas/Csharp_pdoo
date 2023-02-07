using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    public class ArepaProcesada : Arepa, IAsable, ICongelable
    {
        private int temperaturaCoccion;
        private int diasMaximosCongelado;

        public ArepaProcesada(): base()
        {
            temperaturaCoccion = 0;
            diasMaximosCongelado= 0;
        }

        public ArepaProcesada(string tipoDeMasa, string tipoArepa,
                      int diasCaducidad, int numeroMolino, int diasMaximosCongelado, int temperaturaCoccion)
                        : base(tipoDeMasa, tipoArepa, diasCaducidad, numeroMolino)
        {
            this.diasMaximosCongelado = diasMaximosCongelado;
            this.temperaturaCoccion = temperaturaCoccion;
        }

        public int GetDiasMaximosCongelado()
        {
            return diasMaximosCongelado;
        }

        public void SetDiasMaximosCongelado(int diasMaximosCongelado)
        {
            if (diasMaximosCongelado > 0)
                this.diasMaximosCongelado = diasMaximosCongelado;
            else
                this.diasMaximosCongelado = 0;
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

        public string InfoCongelacion()
        {
            string info = $"Días máximos de congelación: {diasMaximosCongelado}";
            return info;
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
                InfoCongelacion() + "\n" +
                InfoCoccion();
            return informacion;
        }
    }
}
