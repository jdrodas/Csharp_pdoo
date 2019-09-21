using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_EmprendimientosDigitales
{
    class EmpresaPodcasts: Empresa
    {
        //atributos de la clase
        private int programasPlaneados, programasPublicados;

        //Constructor de la clase
        public EmpresaPodcasts() : base()
        {
            programasPlaneados = 0;
            programasPublicados = 0;
        }

        public EmpresaPodcasts(string municipio, string tipoRecurso,
            int programasPlaneados, int programasPublicados) : base(municipio, tipoRecurso)
        {
            this.programasPlaneados = programasPlaneados;
            this.programasPublicados = programasPublicados;
        }

        //Propiedades para los atributos
        public int ProgramasPlaneados
        {
            get { return programasPlaneados; }
        }

        public int ProgramasPublicados
        {
            get { return programasPublicados; }
        }
        public override void EvaluaElegibilidad()
        {
            if (programasPlaneados >= 52 && programasPublicados >= 39)
                esElegible = true;
        }
    }
}

