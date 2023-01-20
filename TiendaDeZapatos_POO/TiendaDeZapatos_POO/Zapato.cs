using System;

namespace TiendaDeZapatos_POO
{
    public class Zapato
    {
        //Zona de Atributos
        private string estilo, color;
        private int talla;

        //Zona de Constructor
        public Zapato()
        {
            talla = 0;
            estilo = "ninguno";
            color = "Sin asignar";
        }
        //Zona de Métodos / Propiedades

        /// <summary>
        /// Asigna el valor del atributo Talla
        /// </summary>
        /// <param name="datoTalla">El dato de la talla</param>
        public void AsignaTalla(int datoTalla)
        {
            if (datoTalla >= 28 && datoTalla <= 44)
                talla = datoTalla;
            else
                talla = 0;
        }

        /// <summary>
        /// Obtiene el valor del atributo Talla
        /// </summary>
        /// <returns>La talla asignada</returns>
        public int ObtieneTalla()
        {
            return talla;
        }

        //Zona de Propiedades
        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Talla
        {
            get { return talla; }
            set
            {
                if (value >= 28 && value <= 44)
                    talla = value;
                else
                    talla = 0;
            }
        }
    }
}
