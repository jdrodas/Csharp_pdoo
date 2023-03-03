using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComercioOvejas
{
    public class OvejaLechera : Oveja
    {
        private double litrosLeche;

        public OvejaLechera() : base()
        {
            litrosLeche = 0;
        }

        public double GetLitrosLeche()
        {
            return litrosLeche;
        }

        public void SetLitrosLeche(double litrosLeche)
        {
            this.litrosLeche = litrosLeche;
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
