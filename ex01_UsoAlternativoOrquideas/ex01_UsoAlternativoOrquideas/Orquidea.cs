using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01_UsoAlternativoOrquideas
{
    public class Orquidea
    {
        //Atributos
        private string origen, mesFloracion, utilizacion;

        //Constructor de la clase
        public Orquidea()
        {
            origen = "";
            mesFloracion = "";
            utilizacion = "";
        }

        public Orquidea(string origen, string mesFloracion, string utilizacion)
        {
            this.origen = origen;
            this.mesFloracion = mesFloracion;
            this.utilizacion = utilizacion;
        }

        //Propiedades
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public string MesFloracion
        {
            get { return mesFloracion; }
            set { mesFloracion = value; }
        }

        public string Utilizacion
        {
            get { return utilizacion; }
            set { utilizacion = value; }
        }

        //Metodos
        public string InformacionOrquidea()
        {
            string resultado = $"Esta orquídea es de origen {origen}, \n" +
                $"floreció en {mesFloracion} y se utiliza para {utilizacion} \n";

            return resultado;
        }
    }
}
