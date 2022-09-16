namespace LogicaReforestacion
{
    abstract public class ActividadReforestacion
    {
        //Atributos de la clase
        protected string municipio, tipo;
        protected int cantidadArboles;
        protected float porcentajeSobrevivencia;
        protected bool esExitosa;        

        //Constructor predeterminado
        public ActividadReforestacion()
        {
            municipio = "";
            tipo = "";
            cantidadArboles = 0;
            porcentajeSobrevivencia = 0f;
            esExitosa = false;
        }

        //Constructor sobrecargado
        public ActividadReforestacion(string municipio, 
                                      string tipo, 
                                      int cantidadArboles, 
                                      float porcentajeSobrevivencia)
        {
            this.municipio = municipio;
            this.tipo = tipo;
            this.cantidadArboles = cantidadArboles;
            this.porcentajeSobrevivencia = porcentajeSobrevivencia;

            EvaluaExitoActividad();
        }

        /// <summary>
        /// Obtiene o establece el municipio donde se hace la reforestación
        /// </summary>
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        /// <summary>
        /// Obtiene o establece el tipo de actividad de reforestación
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de arboles en la actividad de reforestación
        /// </summary>
        public virtual int CantidadArboles
        {
            get { return cantidadArboles; }
            set { cantidadArboles = value; }
        }

        /// <summary>
        /// Obtiene o establece el porcentaje de sobrevicencia de los arboles plantados
        /// </summary>
        public virtual float PorcentajeSobrevivencia
        {
            get { return porcentajeSobrevivencia; }
            set
            { 
                porcentajeSobrevivencia = value;

                //Cada vez que se cambie el porcentaje de sobrevivencia,
                //se recalcula el exito de la actividad
                EvaluaExitoActividad();
            }
        }

        /// <summary>
        /// OBtiene si la actividad de reforestación fue exitosa o no
        /// </summary>
        public bool EsExitosa
        {
            get { return esExitosa; }
        }

        /// <summary>
        /// Propiedad General para devolver un recurso específico de la actividad de reforestación
        /// </summary>
        abstract public float RecursoEspecifico
        {
            get;
        }

        /// <summary>
        /// Evalua si la actividad de reforestación fue exitosa
        /// </summary>
        public void EvaluaExitoActividad()
        {
            //Si el porcentaje supera el 70%, fue exitosa
            if (porcentajeSobrevivencia >= 70f)
                esExitosa = true;
            else
                esExitosa = false;
        }

        /*
        COMENTARIO DEL DOCENTE:

        Para visualizar la información de la actividad de reforestación tenemos dos maneras:

        1. Sobreescribir el método ToString() que proviene de la clase genérica Object
           y seguirlo sobreescribiendo en el resto de las clases de la jerarquía de herencia

        2. Crear un método propio (ObtieneInformacion) que lo debes marcar con "virtual" para
           que pueda ser sobreescrito en el resto de las clases de la jerarquía de herencia

        En este ejercicio implementamos las dos, y puedes escoger cual utilizar.
        Ambas hacen lo mismo

        */

        /// <summary>
        /// Obtiene información sobre la actividad de reforestación
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            string informacion = $"Actividad de Reforestación en {municipio} \n" +
                $"Se intentaron plantar {cantidadArboles} y sobrevívió {(porcentajeSobrevivencia)}%\n";

            if (esExitosa)
                informacion += "Fue exitosa!";
            else
                informacion += "No fue exitosa!";

            return informacion;
        }

        /// <summary>
        /// Obtiene la información de la actividad de reforestación
        /// </summary>
        /// <returns>la información solicitada</returns>
        public virtual string ObtieneInformacion()
        {
            string informacion = $"Actividad de Reforestación en {municipio} \n" +
                        $"Se intentaron plantar {cantidadArboles} y sobrevívió {(porcentajeSobrevivencia)}%\n";

            if (esExitosa)
                informacion += "Fue exitosa!";
            else
                informacion += "No fue exitosa!";

            return informacion;
        }
    }
}