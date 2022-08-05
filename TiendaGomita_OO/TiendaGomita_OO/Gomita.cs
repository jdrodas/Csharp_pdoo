using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaGomita_OO
{
    public class Gomita
    {
        //Atributos
        private string color, forma, sabor;

        //Constructor de la clase
        public Gomita()
        {
            color = "";
            forma = "";
            sabor = "";
        }

        /// <summary>
        /// Obtiene o establece el atributo color de la gomita
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// Obtiene o establece el atributo forma de la gomita
        /// </summary>
        public string Forma
        {
            get { return forma; }
            set { forma = value; }
        }

        /// <summary>
        /// Obtiene o establece el atributo sabor de la gomita
        /// </summary>
        public string Sabor
        {
            get { return sabor; }
            set { sabor = value; }
        }

        /// <summary>
        /// Obtiene toda información de los atributos de la gomita
        /// </summary>
        /// <returns>el detalle de la gomita</returns>
        public string ObtieneInformacion()
        {
            string informacion =    $"Sabor: {sabor} "+
                                    $"Color: {color} "+
                                    $"Forma: {forma}";
            return informacion;
        }
    }
}
