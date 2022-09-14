namespace LogicaReforestacion
{
    abstract public class ActividadReforestacion
    {
        //Atributos de la clase
        protected string municipio;
        protected int cantidadArboles;
        protected float porcentajeSobrevivencia;
        protected bool esExitosa;
        protected string tipo;

        #region Constructores

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
        public ActividadReforestacion(string municipio, string tipo, int cantidadArboles, float porcentajeSobrevivencia)
        {
            this.municipio = municipio;
            this.tipo = tipo;
            this.cantidadArboles = cantidadArboles;
            this.porcentajeSobrevivencia = porcentajeSobrevivencia;
            esExitosa= false;
        }

        #endregion Constructores

        #region Propiedades

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

                //Cada vez que se cambie el porcentaje de sobrevivencia, se recalcula el exito de la actividad
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

        #endregion Propiedades

        #region Metodos

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

        /// <summary>
        /// Obtiene información sobre la actividad de reforestación
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            string informacion = $"Actividad de Reforestación en {municipio} \n" +
                $"Se intentaron plantar {cantidadArboles} y sobrevívió {(porcentajeSobrevivencia)}%\n";

            if (esExitosa)
            {
                informacion += "Fue exitosa!";
            }
            else
            {
                informacion += "No fue exitosa!";
            }
            return informacion;
        }

        #endregion Metodos
    }
}