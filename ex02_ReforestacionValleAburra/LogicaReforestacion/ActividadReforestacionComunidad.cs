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
            int cantidadArboles, 
            float porcentajeSobrevivencia,
            int cantidadVoluntarios):base(municipio,
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

        public override float RecursoEspecifico
        {
            get { return cantidadVoluntarios; }
            set { cantidadVoluntarios = (int)value; }
        }


        public override string ToString()
        {
            string informacion = base.ToString() +
                $"\nActividad realizada por la comunidad con {cantidadVoluntarios} voluntarios";

            return informacion;
        }
    }
}
