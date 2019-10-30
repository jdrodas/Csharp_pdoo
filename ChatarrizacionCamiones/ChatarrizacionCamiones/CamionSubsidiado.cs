using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatarrizacionCamiones
{
    class CamionSubsidiado : Camion
    {
        private int cantidadInfracciones;
        private bool viable;

        public CamionSubsidiado() : base()
        {
            cantidadInfracciones = -1;
            viable = false;
        }
        public CamionSubsidiado(int tiempoUso, float capacidadCarga, float kmRecorridos, int cantidadInfracciones)
            : base(tiempoUso, capacidadCarga, kmRecorridos)
        {
            this.cantidadInfracciones = cantidadInfracciones;
            viable = false;            
        }
        public int CantidadInfracciones
        {
            get { return cantidadInfracciones; }
            set
            {
                if (value > 0 && value <= 20)
                    cantidadInfracciones = value;
            }
        }
        public bool Viable
        {
            get { return viable; }
        }

        public void EsValido()
        {
            if (TiempoUso > 15 && capacidadCarga < 18 && kmRecorridos > 4)
                chatarrizable = true;
            if (chatarrizable == true && cantidadInfracciones <= 5)
                viable = true;
        }
        public override string InfoCamion()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append(base.InfoCamion() +
                "Cantidad de Infracciones: " + 
                cantidadInfracciones + Environment.NewLine);

            return resultado.ToString();
        }
    }
}
