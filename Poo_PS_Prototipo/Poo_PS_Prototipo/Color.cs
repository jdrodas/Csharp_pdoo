using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Prototipo
{
    public class Color : PrototipoColor
    {
        private int rojo;
        private int verde;
        private int azul;

        public Color(int rojo, int verde, int azul)
        {
            this.rojo = rojo;
            this.verde = verde;
            this.azul = azul;
        }

        /// <summary>
        /// Devuelve una copia "superficial" del método actual
        /// </summary>
        /// <returns></returns>
        public override PrototipoColor Clonar()
        {
            return this.MemberwiseClone() as PrototipoColor;
        }

        public override string ToString()
        {
            string informacion = $"Este color se llama {Nombre} y sus componentes RGB son ({rojo}, {verde}, {azul})";
            return informacion;
        }
    }
}
