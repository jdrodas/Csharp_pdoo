using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatarrizacionCamiones
{
    class ControlSimulacion
    {
        private CamionSubsidiado[] misCamiones;

        public ControlSimulacion()
        {
            misCamiones = new CamionSubsidiado[1000];            
        }

        public void InicializaSimulacion()
        {
            int v_tiempoUso;//valores entre 0 y 30
            float v_kmRecorridos;//valores entre 1.5 y 25
            float v_CapacidadCarga;//valores entre 0.8 y 12
            int v_infracciones;//valores entre 0 y 20

            Random aleatorio = new Random(DateTime.Now.Millisecond);

            //recorremos el arreglo
            for (int i = 0; i < misCamiones.Length; i++)
            {
                v_tiempoUso = aleatorio.Next(0, 31);
                v_CapacidadCarga = ((float)aleatorio.Next(15, 250)/10);
                v_kmRecorridos = ((float)aleatorio.Next(8, 120)/10);
                v_infracciones = aleatorio.Next(0, 21);

                misCamiones[i] = new CamionSubsidiado(v_tiempoUso, v_CapacidadCarga, 
                    v_kmRecorridos, v_infracciones);

                misCamiones[i].EsValido();
            }
        }
        public string TotalesCamiones()
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < misCamiones.Length; i++)
                if (misCamiones[i].Viable == true)
                    resultado.Append("Camion: " + (i + 1) + Environment.NewLine + 
                        misCamiones[i].InfoCamion() +
                        "Es viable de subsidio" + Environment.NewLine + Environment.NewLine);

            return resultado.ToString();
        }
    }
}
