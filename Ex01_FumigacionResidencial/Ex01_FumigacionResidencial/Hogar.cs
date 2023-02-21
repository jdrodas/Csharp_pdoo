using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_FumigacionResidencial
{
    public class Hogar
    {
        private bool estaFumigado;
        private Fumigacion accionFumigacion;

        public Hogar()
        {
            estaFumigado= false;
            accionFumigacion =new Fumigacion();
        }

        public Hogar(Fumigacion accionFumigacion)
        {
            this.accionFumigacion = accionFumigacion;

            if(accionFumigacion.GetMetodoFumigacion() != string.Empty &&
                accionFumigacion.GetPlaga() != string.Empty)
                estaFumigado= true;
            else
                estaFumigado= false;
        }

        public bool GetEstaFumigado()
        {
            return estaFumigado;
        }

        public Fumigacion GetAccionFumigacion()
        {
            return accionFumigacion;
        }

        public override string ToString()
        {
            string informacion;

            if (estaFumigado)
            {
                informacion = $"Este es un hogar fumigado con {accionFumigacion.GetMetodoFumigacion()} " +
                    $"para la plaga {accionFumigacion.GetPlaga()}";
            }
            else
            {
                informacion = "Este hogar no fue fumigado";
            }

            return informacion;
        }
    }
}
