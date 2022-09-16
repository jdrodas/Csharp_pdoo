using System;

namespace LogicaReforestacion
{
    public class ActividadReforestacionComunidad : ActividadReforestacion
    {
        private int cantidadVoluntarios;

        public ActividadReforestacionComunidad() : base()
        {
            cantidadVoluntarios = 0;
        }

        public ActividadReforestacionComunidad(string municipio,
            string tipo,
            int cantidadArboles, 
            float porcentajeSobrevivencia,
            int cantidadVoluntarios):base(municipio,
                                          tipo,
                                          cantidadArboles,
                                          porcentajeSobrevivencia)
        {
            this.cantidadVoluntarios = cantidadVoluntarios;
        }

        public int CantidadVoluntarios
        {
            get { return cantidadVoluntarios; }
            set { cantidadVoluntarios = value; }
        }

        /// <summary>
        /// Obtiene el recurso específico de la cantidad de voluntarios para la actividad con Comunidad
        /// </summary>
        override public float RecursoEspecifico
        {
            get { return cantidadVoluntarios; }
        }


        public override string ToString()
        {
            string informacion = base.ToString() +
                $"\nActividad realizada por la comunidad con {cantidadVoluntarios} voluntarios";

            return informacion;
        }

        public override string ObtieneInformacion()
        {
            string informacion = base.ObtieneInformacion() +
                $"\nActividad realizada por la comunidad con {cantidadVoluntarios} voluntarios";

            return informacion;

        }
    }
}
