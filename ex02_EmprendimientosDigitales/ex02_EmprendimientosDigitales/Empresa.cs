using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_EmprendimientosDigitales
{
    abstract class Empresa
    {
        //atributos de la clase
        protected string municipio, tipoRecurso;
        protected bool esElegible;

        //constructor de la clase
        public Empresa()
        {
            municipio = "";
            tipoRecurso = "";
            esElegible = false;
        }

        public Empresa(string municipio, string tipoRecurso)
        {
            this.municipio = municipio;
            this.tipoRecurso = tipoRecurso;
            esElegible = false;
        }

        //Propiedades para los atributos
        public string Municipio
        {
            get { return municipio; }
        }

        public string TipoRecurso
        {
            get { return tipoRecurso; }
        }

        public bool EsElegible
        {
            get { return esElegible; }
        }

        public abstract void EvaluaElegibilidad();
    }
}
