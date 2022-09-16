using LogicaReforestacion;

namespace ex02_ReforestacionValleAburra
{
    public class Program
    {
        static void Main(string[] args)
        {
            GestionReforestacion corantioquia = new GestionReforestacion();
            
            Console.WriteLine("Gestion de reforestación en el valle de Aburrá");
            Console.WriteLine("Se realizarán actividades en los siguientes municipios:");

            foreach(string nombreMunicipio in corantioquia.LosMunicipios)
                Console.WriteLine($"- {nombreMunicipio}");

            Console.WriteLine("\nLos siguientes son los tipos de actividad:");

            foreach (string tipoActividad in corantioquia.LosTiposActividades)
                Console.WriteLine($"- {tipoActividad}");

            //Aqui ejecutamos la reforestación
            corantioquia.EjecutaReforestacion();

            //Visualizamos resultados
            Console.WriteLine("\n\n************************************");
            Console.WriteLine(" Resultados Obtenidos");
            Console.WriteLine("************************************\n");

            Console.WriteLine("Información por municipios:\n");

            for (int i = 0; i < corantioquia.LosMunicipios.Length; i++)
            {
                Console.WriteLine($"\tMunicipio: {corantioquia.LosMunicipios[i]}");
                Console.WriteLine($"\tTotal Actividades: {corantioquia.TotalActividadesMunicipio[i]}");
                Console.WriteLine($"\tTotal arboles sobrevivientes: {corantioquia.TotalArbolesSobrevivientesMunicipio[i]}\n");
            }

            Console.WriteLine("Información por Tipos de actividad:\n");
            for (int i = 0; i < corantioquia.LosTiposActividades.Length; i++)
            {
                Console.WriteLine($"\tTipo de Actividad: {corantioquia.LosTiposActividades[i]}");
                Console.WriteLine($"\tTotal Actividades: {corantioquia.TotalActividadesTipo[i]}");
                Console.WriteLine($"\tTotal Actividades exitosas: {corantioquia.TotalActividadesExitosasTipo[i]}\n");
            }

            Console.WriteLine($"Total agua utilizada: {corantioquia.TotalAguaUtilizada} galones");
        }
    }
}



