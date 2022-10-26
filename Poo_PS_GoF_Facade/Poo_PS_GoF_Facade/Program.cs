namespace Poo_PS_GoF_Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el patrón GoF - Fachada");
            Console.WriteLine("Evaluación de Crédito\n\n");

            //Aqui leemos la información del cliente
            string? nombreCliente;
            float valorPrestamo, valorCesantias;
            int puntajeDataCredito;

            bool datosCorrectos = false;

            do
            {
                try
                {
                    Console.Write("\nIngresa el nombre del cliente: ");
                    nombreCliente = Console.ReadLine();

                    Console.Write("Ingresa el valor del préstamo: ");
                    valorPrestamo = float.Parse(Console.ReadLine()!);

                    Console.Write("Ingresa el valor de las Cesantías: ");
                    valorCesantias = float.Parse(Console.ReadLine()!);

                    Console.Write("Ingresa el puntaje de Datacrédito: ");
                    puntajeDataCredito = int.Parse(Console.ReadLine()!);

                    datosCorrectos = true;

                    EntidadCrediticia laEntidad = new EntidadCrediticia(
                        nombreCliente!, 
                        valorPrestamo, 
                        valorCesantias, 
                        puntajeDataCredito);

                    //Aqui validamos si la información del cliente es correcta
                    if (laEntidad.ValidaInfoCliente() == false)
                    {
                        Console.WriteLine($"No es posible realizarle un prestamo a {nombreCliente}" +
                            $"por un monto de ${valorPrestamo}");
                    }
                    else
                    {
                        laEntidad.EstudiaCredito();
                        Console.WriteLine(laEntidad.ObtieneResultadoValidacion());
                    }
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("\nEl dato ingresado no es válido. Intenta nuevamente.");
                    Console.WriteLine(elError.Message);
                }
            }
            while (datosCorrectos == false);
        }
    }
}
