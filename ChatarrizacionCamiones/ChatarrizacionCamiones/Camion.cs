using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatarrizacionCamiones
{
    class Camion
    {
        protected int tiempoUso;
        protected float kmRecorridos, capacidadCarga;
        protected bool chatarrizable;

        public Camion()
        {
            tiempoUso = -1;
            capacidadCarga = 0f;
            kmRecorridos = 0f;
            chatarrizable = false;

        }
        public Camion(int tiempoUso, float capacidadCarga, float kmRecorridos)
        {
            this.tiempoUso = tiempoUso;
            this.capacidadCarga = capacidadCarga;
            this.kmRecorridos = kmRecorridos;
            chatarrizable = true;
        }

        public int TiempoUso
        {
            get { return tiempoUso; }
            set
            {
                if (value >= 0 && value <= 30)
                    tiempoUso = value;
            }
        }
        public float CapacidadCarga
        {
            get { return capacidadCarga; }
            set
            {
                if (value >= 1.5f && value <= 25f)
                    capacidadCarga = value;
            }
        }
        public float KmRecorridos
        {
            get { return kmRecorridos; }
            set
            {
                if (value >= 0.8f && value <= 12f)
                    kmRecorridos = value;
            }
        }
        public bool Chatarrizable
        {
            get { return chatarrizable; }
        }

        public virtual string InfoCamion()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append("La informacion de este camion es: " + Environment.NewLine +
                "Tiempo de uso: " + tiempoUso + " años" + Environment.NewLine +
                "Capacidad de carga: " + capacidadCarga.ToString("0.00") + " Toneladas" + Environment.NewLine +
                "Kilometros Recorridos: " + kmRecorridos.ToString("0.00") + " millones" + Environment.NewLine);

            return resultado.ToString();
        }
    }
}
