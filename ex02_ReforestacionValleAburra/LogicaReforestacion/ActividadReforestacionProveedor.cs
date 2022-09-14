using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaReforestacion
{
    public class ActividadReforestacionProveedor: ActividadReforestacion
    {
        private float galonesAgua;

        public ActividadReforestacionProveedor() : base()
        {
            galonesAgua = 0f;
        }

        public ActividadReforestacionProveedor(string municipio,
            int cantidadArboles,
            float porcentajeSobrevivencia) : base(municipio,
                                          cantidadArboles,
                                          porcentajeSobrevivencia)
        {
            CalculaGalonesAgua();
        }

        public float GalonesAgua
        {
            get { return galonesAgua; }
        }

        public override float RecursoEspecifico
        {
            get { return galonesAgua; }
            set
            {
                //Recibe un valor pero se invoca el recalculo de los galones de Agua
                CalculaGalonesAgua();
            }
        }


        public void CalculaGalonesAgua()
        {
            galonesAgua = 
                10 * (cantidadArboles * porcentajeSobrevivencia) / 100;
        }

        public override string ToString()
        {
            string informacion = base.ToString() +
                $"\nActividad realizada por proveedor con {galonesAgua} galones de agua";

            return informacion;
        }
    }
}
