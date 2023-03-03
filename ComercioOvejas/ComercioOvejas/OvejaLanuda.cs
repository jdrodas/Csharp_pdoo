using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComercioOvejas
{
    public class OvejaLanuda : Oveja
    {
        private int cantidadLana;

        public OvejaLanuda() : base()
        {
            cantidadLana = 0;
        }

        public int GetCantidadLana()
        {
            return cantidadLana;
        }

        public void SetCantidadLana(int cantidadLana)
        {
            this.cantidadLana = cantidadLana;
        }

        public override void EvaluaSiEsApta()
        {
            //SI(algo se cumple) entonces
            esApta = true;
            //De lo contrario
            esApta = false;
        }
    }
}
