using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_EmprendimientosDigitales
{
    class EmpresaLibros : Empresa
    {
        //atributos de la clase
        private int librosPlaneados, librosPublicados;

        //Constructor de la clase
        public EmpresaLibros() : base()
        {
            librosPlaneados = 0;
            librosPublicados = 0;
        }

        public EmpresaLibros(string municipio, string tipoRecurso,
            int librosPlaneados, int librosPublicados) : base(municipio, tipoRecurso)
        {
            this.librosPlaneados = librosPlaneados;
            this.librosPublicados = librosPublicados;
        }

        //Propiedades para los atributos
        public int LibrosPlaneados
        {
            get { return librosPlaneados; }
        }

        public int LibrosPublicados
        {
            get { return librosPublicados; }
        }
        public override void EvaluaElegibilidad()
        {
            if (librosPlaneados >= 7 && librosPublicados >= 5)
                esElegible = true;
        }
    }
}

