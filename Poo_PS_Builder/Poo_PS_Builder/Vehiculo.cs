using System.Collections.Generic;


namespace Poo_PS_Builder
{
    public class Vehiculo
    {
        //Atributos
        private string tipoVehiculo;
        private Dictionary<string, string> partes;

        //Constructor de la clase
        public Vehiculo(string tipoVehiculo)
        {
            this.tipoVehiculo = tipoVehiculo;
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
            string informacion = $"Este vehiculo es {tipoVehiculo}.\n" +
                $"Chasis: {partes["chasis"]} \n" +
                $"Motor: {partes["motor"]} \n" +
                $"# Ruedas: {partes["ruedas"]}\n" +
                $"Puertas: {partes["puertas"]}\n";

            if(partes.ContainsKey("extintor"))
                informacion += $"extintor: {partes["extintor"]}\n";
            else
                informacion += $"No vino con extintor, sople!\n";

            return informacion;
        }
    }
}
