using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaReforestacion
{
    public class ActividadReforestacionProveedor: ActividadReforestacion
    {
        //Atributos
        private float galonesAgua;

        //Constructor Predeterminado
        public ActividadReforestacionProveedor() : base()
        {
            galonesAgua = 0f;
        }

        //ConstructorSobreCargado
        public ActividadReforestacionProveedor(string municipio,
            string tipo,
            int cantidadArboles,
            float porcentajeSobrevivencia) 
        {
            this.municipio = municipio;
            this.tipo = tipo;
            this.cantidadArboles = cantidadArboles;
            this.porcentajeSobrevivencia = porcentajeSobrevivencia;

            //Como se cambió el porcentaje de sobrevivencia, en esta clase se debe
            //- recalcular los galones de agua
            //- recalcular si la actividad fue exitosa
            CalculaGalonesAgua();
            EvaluaExitoActividad();
        }

        // Parece que no se necesita propiedad para los galones de agua... 
        // Hagámosla de todas formas

        /// <summary>
        /// Obtiene los galones de agua utilizados en la actividad de reforestación
        /// </summary>        
        public float GalonesAgua
        {
            get { return galonesAgua; }
        }


        /// <summary>
        /// Obtiene o establece la cantidad de arboles
        /// </summary>
        public override int CantidadArboles
        {
            get { return cantidadArboles; }
            set
            {
                cantidadArboles = value;
                CalculaGalonesAgua();
            }
        }

        /// <summary>
        /// Obtiene o establece el porcentaje de sobrevivencia
        /// </summary>
        public override float PorcentajeSobrevivencia
        {
            get { return porcentajeSobrevivencia; }
            set
            {
                porcentajeSobrevivencia = value;

                //Cada vez que se cambie el porcentaje de sobrevivencia, se recalcula el exito de la actividad
                EvaluaExitoActividad();

                //Cuando es proveedor, cada vez que cambie el porcentaje, hay que recalcular los galones de agua
                CalculaGalonesAgua();
            }
        }

        /// <summary>
        /// Obtiene el recurso específico de los galones de agua para la actividad con proveedor
        /// </summary>
        override public float RecursoEspecifico
        {
            get { return galonesAgua; }
        }

        /// <summary>
        /// Calcula los galones de agua utilizados según la cantidad de arboles que sobrevivieron
        /// </summary>
        public void CalculaGalonesAgua()
        {
            // Se necesitan 10 galones por cada arbol que sobreviva
            galonesAgua = 
                10 * (cantidadArboles * (porcentajeSobrevivencia/ 100)) ;
        }

        /// <summary>
        /// Obtiene información sobre la actividad de reforestación
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string informacion = base.ToString() +
                $"\nActividad realizada por proveedor con {galonesAgua} galones de agua";

            return informacion;
        }

        public override string ObtieneInformacion()
        {
            string informacion = base.ToString() +
                $"\nActividad realizada por proveedor con {galonesAgua} galones de agua";

            return informacion;
        }
    }
}
