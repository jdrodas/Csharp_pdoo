using System;

namespace TiendaDeZapatos_POO
{
    public class Zapato
    {
        //Zona de Atributos
        protected string estilo, color;
        protected int talla;

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
        public void SetTalla(int datoTalla)
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
        public int GetTalla()
        {
            return talla;
        }

        /// <summary>
        /// Obtiene el valor del atributo Estilo
        /// </summary>
        /// <returns>El Estilo asignado</returns>
        public string GetEstilo()
        {
            return estilo;
        }

        /// <summary>
        /// Asigna el valor del atributo Talla
        /// </summary>
        /// <param name="datoEstilo">El dato del estilo</param>
        public void SetEstilo(string datoEstilo)
        {
            estilo = datoEstilo;
        }

        /// <summary>
        /// Obtiene el valor del atributo Color
        /// </summary>
        /// <returns>El Estilo asignado</returns>
        public string GetColor()
        {
            return color;
        }

        /// <summary>
        /// Asigna el valor del atributo Color
        /// </summary>
        /// <param name="datoColor">El dato del color</param>
        public void SetColor(string datoColor)
        {
            color = datoColor;
        }

        //Zona de Propiedades
        
        /// <summary>
        /// Obtiene o asigna el valor del estilo
        /// </summary>
        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        /// <summary>
        /// Obtiene o asigna el valor del color
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// Obtiene o asigna el valor de la talla
        /// </summary>
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

        /// <summary>
        /// Obtiene una cadena de caracteres con la información del zapato
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string resultado = $"Talla: {talla}, Color: {color}, Estilo: {estilo}";
            return resultado;
        }
    }
}
