using System;

namespace ValidacionDocumento
{
    class Documento
    {
        //atributos de la clase
        private string tipo, genero;
        private long numero;

        //Constructor de la clase
        public Documento()
        {
            tipo = "0";
            numero = 0;
            genero = "0";
        }

        //aqui definimos las propiedades para los atributos

        /// <summary>
        /// Obtiene o establece el número del documento de identidad
        /// </summary>
        public long Numero
        {
            get { return numero; }
            set
            {
                if (value > 0)
                    numero = value;
            }
        }

        /// <summary>
        /// Establece el número del documento
        /// </summary>
        /// <param name="valor">número del documento</param>
        public void SetNumero(long valor)
        {
            if (valor >= 0)
                numero = valor;
        }

        /// <summary>
        /// Obtiene el número del documento
        /// </summary>
        /// <returns>el número del documento</returns>
        public long GetNumero()
        {
            return numero;
        }

        /// <summary>
        /// Obtiene o establece el dato del género biológico de la persona dueña del documento
        /// </summary>
        public string Genero
        {
            get { return genero; }
            set
            {
                if (value == "M" || value == "F")
                {
                    genero = value;
                }
            }
        }

        /// <summary>
        /// Obtiene o establece el tipo de documento de identidad
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set
            {
                if (value == "T" || value == "C")
                {
                    tipo = value;
                }
            }
        }
    }
}
