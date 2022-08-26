using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioOvejas
{
    public class OvejaLechera : Oveja
    {
        private int litrosLeche;

        public OvejaLechera() : base()
        {
            litrosLeche = 0;
        }

        public OvejaLechera(int peso, 
                            int edad, 
                            string sexo, 
                            int litrosLeche, 
                            int cantidadLana): base(edad,peso,sexo,cantidadLana)
        {
            this.litrosLeche = litrosLeche;
        }
        public int LitrosLeche
        {
            get { return litrosLeche; } 
            set { litrosLeche = value; }    
        }

        public override string ToString()
        {
            string resultado = base.ToString();

            resultado += $"Produce {litrosLeche} litros de leche\n";
            
            return resultado;
        }
    }
}
