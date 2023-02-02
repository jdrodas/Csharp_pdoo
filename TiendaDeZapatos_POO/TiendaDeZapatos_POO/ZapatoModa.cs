using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeZapatos_POO
{
    public class ZapatoModa : Zapato
    {
        //Zona de atributos / campos
        private int cantidad;

        /// <summary>
        /// Constructor predeterminado
        /// </summary>
        public ZapatoModa() : base()
        {
            cantidad = 0;
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        public ZapatoModa(string estilo, string color, int talla, int cantidad)
        {
            this.cantidad = cantidad;
            this.color = color;
            this.talla = talla;
            this.estilo = estilo;
        }

        /// <summary>
        /// Obtiene la cantidad de zapatos encontrada para el zapato de moda
        /// </summary>
        /// <returns>el valor del atributo</returns>
        public int GetCantidad()
        {
            return cantidad;
        }

        /// <summary>
        /// Asigna el valor de la cantidad de zapatos encontrada para el zapato de moda
        /// </summary>
        /// <param name="datoCantidad">el valor de la cantidad</param>
        public void SetCantidad(int datoCantidad)
        {
            if (datoCantidad > 0)
                cantidad = datoCantidad;
            else
                cantidad = 0;
        }

        // Zona de propiedades
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value > 0)
                    cantidad = value;
                else
                    cantidad = 0;
            }
        }

    }
}
