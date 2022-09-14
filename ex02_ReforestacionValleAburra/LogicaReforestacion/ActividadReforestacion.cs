namespace LogicaReforestacion
{
    abstract public class ActividadReforestacion
    {
        protected string municipio;
        protected int cantidadArboles;
        protected float porcentajeSobrevivencia;
        protected bool esExitosa;

        public ActividadReforestacion()
        {
            municipio = "";
            cantidadArboles = 0;
            porcentajeSobrevivencia = 0f;
            esExitosa = false;
        }

        public ActividadReforestacion(string municipio, int cantidadArboles, float porcentajeSobrevivencia)
        {
            this.municipio = municipio;
            this.cantidadArboles = cantidadArboles;
            this.porcentajeSobrevivencia = porcentajeSobrevivencia;
            esExitosa= false;
        }

        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        public int CantidadArboles
        {
            get { return cantidadArboles; }
            set { cantidadArboles = value; }
        }

        public float PorcentajeSobrevivencia
        {
            get { return porcentajeSobrevivencia; }
            set
            { 
                porcentajeSobrevivencia = value;
                EvaluaExitoActividad();
            }
        }

        public bool EsExitosa
        {
            get { return esExitosa; }
        }

        abstract public float RecursoEspecifico
        { 
            get;
            set;
        }

        public void EvaluaExitoActividad()
        {
            if (porcentajeSobrevivencia >= 70f)
                esExitosa = true;
            else
                esExitosa = false;
        }

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
    }
}