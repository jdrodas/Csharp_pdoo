using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_EmprendimientosDigitales
{
    class EmpresaVideoJuegos: Empresa
    {
        //atributos de la clase
        private int juegosPlaneados, juegosPublicados;

        //Constructor de la clase
        public EmpresaVideoJuegos() : base()
        {
            juegosPlaneados = 0;
            juegosPublicados = 0;
        }

        public EmpresaVideoJuegos(string municipio, string tipoRecurso,
            int juegosPlaneados, int juegosPublicados) : base(municipio, tipoRecurso)
        {
            this.juegosPlaneados = juegosPlaneados;
            this.juegosPublicados = juegosPublicados;
        }

        //Propiedades para los atributos
        public int JuegosPlaneados
        {
            get { return juegosPlaneados; }
        }

        public int JuegosPublicados
        {
            get { return juegosPublicados; }
        }
        public override void EvaluaElegibilidad()
        {
            if (juegosPlaneados >= 10 && juegosPublicados >= 4)
                esElegible = true;
        }
    }
}
