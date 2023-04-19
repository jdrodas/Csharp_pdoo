using System.Collections.Generic;
using System.Text;

namespace Poo_PS_GoF_Builder
{
    public class Vehiculo
    {
        //Atributos
        private string tipoVehiculo;
        private Dictionary<string, string> partes;

        //Constructor de la clase
        public Vehiculo(string tipoVehiculo)
        {
            this.tipoVehiculo = tipoVehiculo!;
            partes = new Dictionary<string, string>();
        }

        //Propiedad para acceder a un "registro" del diccionario
        public string this[string clave]
        {
            get { return partes[clave]; }
            set { partes[clave] = value; }
        }

        //Metodos
        public string Visualizar()
        {
            //utilizaremos un StringBuilder para concatenar información
            //más eficientemente utilizando un ciclo

            StringBuilder informacion = new StringBuilder();

            informacion.Append($"Este vehiculo es {tipoVehiculo}.\n");

            //Aqui recorremos el diccionario con un ciclo
            foreach(KeyValuePair<string, string> unaParte in partes)
                informacion.Append($"{unaParte.Key}: {unaParte.Value} \n");

            if (!partes.ContainsKey("extintor"))
                informacion.Append("*** No vino con extintor, sople! ***\n");

            return informacion.ToString();
        }
    }
}
