/*
Programa:       ValidacionDocumento
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Validador Documentos de Identidad Colombianos

Se desea implementar una funcionalidad que permita validar la estructura y concordancia de la 
información que se suministra al momento del registro de un usuario en una aplicación, de tal 
manera que se de cumplimiento a las normas de protección de datos personales.

La funcionalidad se evaluará de manera independiente, realizando una implementación en aplicación 
de consola. Se deberán ingresar los datos de 5 personas y al final ofrecer el resultado de la 
validación de manera tabulada.

Como es de esperarse, quien utiliza la herramienta posiblemente cometa errores de digitación al 
momento de ingresar los datos, por lo que se establece los siguientes lineamientos como críticos 
para la validación de estructura:

•	El dato del documento de identidad siempre será numérico. No se aceptan espacios, letras o delimitadores entre otros.
•	Solo se analizan dos tipos de documento: T – Tarjeta de Identidad y C – Cédula de Ciudadanía.
•	Solo se recibe para el sexo biológico, los valores M – Masculino y F – Femenino.

En caso de incumplir cualquiera de estos casos, se genera una alerta y se debe solicitar 
ingresar nuevamente los valores para esa persona.

Para la validación de concordancia, se tiene establecido los siguientes lineamientos

•	OK - 1. La Tarjeta de Identidad debe tener una longitud de 10 u 11.
•	OK - 2. El número de la Tarjeta de Identidad de longitud 10 debe ser mayor a 1.000.000.000.
•	OK - 3. Si la tarjeta de identidad es de longitud 11, los 6 primeros dígitos deben corresponder a la fecha de nacimiento (aammdd).
•	OK - 4. Si la tarjeta de identidad es de longitud 11, el 10o carácter debe ser 1,3,5,7,9 cuando es una mujer.
•	OK - 5. Si la tarjeta de identidad es de longitud 11, el 10o carácter debe ser 2,4,6,8,0 cuando es un hombre.

•	OK - 6. El número de la Cédula de ciudadanía de longitud 10 debe ser mayor a 1.000.000.000.
•	OK - 7. La Cédula de ciudadanía de una mujer debe tener una longitud de 8 o 10.
•	OK - 8. El número de la Cédula de ciudadanía de una mujer de longitud 8 debe estar entre 20.000.000 y 69.999.999.
•	OK - 9. La Cédula de ciudadanía de un hombre debe tener una longitud de 3,4,5,6,7,8 o 10.
•	OK - 10. El número de la Cédula de ciudadanía de un hombre con longitud de 3,4,5,6,7 u 8 debe estar entre 1 y 19.999.999 o 70.000.000 y 99.999.999.

Presente por favor casos de prueba que permitan verificar la correcta implementación de los criterios de concordancia presentados.

Implementación

Realice una aplicación de consola que tenga separación funcional entre presentación y lógica de la validación.
*/

using System;

namespace ValidacionDocumento
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPersonas = 5; //Personas a las que se le validará el documento

            Console.WriteLine("Programa para validar documentos de identidad");
            Console.WriteLine("Se validará estructura y concordancia del documento para {0} personas", totalPersonas);

            //aqui declaramos el arreglo de documentos de Persona
            Documento[] losDocs = new Documento[totalPersonas];

            //Aqui hacemos el ciclo para capturar la información de los documentos
            int contadorDocs = 0;
            string datoTipo, datoGenero;
            long datoNumero;

            while (contadorDocs < totalPersonas)
            {
                try
                {
                    Console.WriteLine("\nIngresando información para la persona No. {0}", contadorDocs + 1);

                    Console.Write("Género de la persona: (F)emenino o (M)ásculino: ");
                    datoGenero = Console.ReadLine().ToUpper();
                    Console.Write("Tipo de documento: (T)arjeta o (C)édula: ");
                    datoTipo = Console.ReadLine().ToUpper();
                    Console.Write("Número del documento: ");
                    datoNumero = long.Parse(Console.ReadLine());

                    //aqui validamos el género
                    if (datoGenero != "F" && datoGenero != "M")
                        Console.WriteLine("Dato del género equivocado, intenta nuevamente!");

                    //aqui validamos el tipo de documento
                    if (datoTipo != "T" && datoTipo != "C")
                        Console.WriteLine("Dato del tipo de documento equivocado, intenta nuevamente!");

                    //aqui validamos que el número sea positivo
                    if (datoNumero <= 0)
                        Console.WriteLine("los números del documento deben ser positivos, intenta nuevamente!");

                    //Si están bien, se asignan
                    if ((datoGenero == "M" || datoGenero == "F") && (datoTipo == "T" || datoTipo == "C") && (datoNumero > 0))
                    {
                        losDocs[contadorDocs] = new Documento();
                        losDocs[contadorDocs].Genero = datoGenero;
                        losDocs[contadorDocs].Tipo = datoTipo;
                        losDocs[contadorDocs].Numero = datoNumero;

                        //como está correcto, seguimos con el siguiente documento
                        //esta es la condición de salida del ciclo de control
                        contadorDocs++;
                    }
                }
                catch (FormatException error)
                {
                    Console.WriteLine("El dato del número del documento está en formato errado. Intenta nuevamente");
                    Console.WriteLine(error.Message);
                }
            }

            Console.WriteLine("\nDocumentos ingresados, validando concordancia...");
            Console.WriteLine("------------------------------------------------\n");

            ValidadorDocumento miValidador = new ValidadorDocumento();

            for (int i = 0; i < losDocs.Length; i++)
            {
                Console.WriteLine("Persona No. {0}, género: {1}, tipo doc: {2}, número: {3}",
                    i + 1,
                    losDocs[i].Genero,
                    losDocs[i].Tipo,
                    losDocs[i].Numero);

                miValidador.ElDocumento = losDocs[i];

                Console.WriteLine("Resultado: {0}\n", miValidador.ResultadoValidacion);
            }

            Console.WriteLine("\nFin del programa.");
        }
    }
}
