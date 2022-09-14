/*
 Este proyecto Está MUY INCOMPLETO!
 
Le falta:

OK! - Crear interfaz de usuario en clase program
OK! - Invocar el constructor de la gestionReforestacion
OK! - Totalizar actividades por municipio
OK! - Totalizar arboles sobrevivientes por municipio
- Totalizar actividades por tipo
- Totalizar actividades exitosas

- Totalizar galones
- Visualizar resultados
 */

using LogicaReforestacion;

namespace ex02_ReforestacionValleAburra
{
    public class Program
    {
        static void Main(string[] args)
        {
            GestionReforestacion miGestion = new GestionReforestacion();
            
            Console.WriteLine("Gestion de reforestación en el valle de aburra");
            Console.WriteLine("Se realizarán actividades en los siguientes municipios");

            foreach(string nombreMunicipio in miGestion.LosMunicipios)
                Console.WriteLine($"- {nombreMunicipio}");

            //Aqui ejecutamos los totalizadores requeridos
            miGestion.CalculaTotalActividadesMunicipio();
            miGestion.CalculaTotalArbolesSobrevivientesMunicipio();


            //Aqui visualizamos resultados
            Console.WriteLine("\n==============================");
            Console.WriteLine("   Resultados Obtenidos");
            Console.WriteLine("==============================\n");

            int contadorActividades = 0;
            for (int i = 0; i < miGestion.LosMunicipios.Length; i++)
            {
                Console.WriteLine($"Municipio: {miGestion.LosMunicipios[i]}, " +
                    $"Total actividades: {miGestion.TotalActividadesMunicipio[i]}");
                Console.WriteLine($"sobrevivieron {miGestion.TotalArbolesSobrevivientesMunicipio[i]} árboles\n");
                
                contadorActividades += miGestion.TotalActividadesMunicipio[i];
            }

            Console.WriteLine($"Total Actividades: {contadorActividades}");


                

        }
    }
}



