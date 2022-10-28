using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patrón GoF - Cadena de Responsabilidad");
            Console.WriteLine("Aprobación de Pedidos");

            //1 - Definir nombres y montos de la jerarquía de ejecutivos
            Console.WriteLine("\n *** Definición de la jerarquía de ejecutivos");

            Ejecutivo[] JerarquiaEjecutivos = new Ejecutivo[3];
            JerarquiaEjecutivos[0] = new Coordinador();
            JerarquiaEjecutivos[1] = new Director();
            JerarquiaEjecutivos[2] = new Presidente();

            //Aqui definimos nombres, montos y jefes
            for (int i = 0; i < JerarquiaEjecutivos.Length; i++)
            {
                AsignaValoresEjecutivo(JerarquiaEjecutivos[i]);

                //Aqui asignamos los jefes
                if (i < JerarquiaEjecutivos.Length - 1)
                    JerarquiaEjecutivos[i].AsignaJefe(JerarquiaEjecutivos[i + 1]);
            }

            //2 - Validar que los montos de aprobación estén de acuerdo a la jerarquía
            string resultadoEvaluacion;
            bool evaluacionJerarquiaCorrecta = EvaluaJerarquia(JerarquiaEjecutivos, out resultadoEvaluacion);

            if (evaluacionJerarquiaCorrecta == false)
            {
                Console.WriteLine("La jerarquía de ejecutivos no es válida");
                Console.WriteLine($"{resultadoEvaluacion}");
            }
            else
            {
                //De lo contrario, la jerarquía es correcta podemos hacer el pedido de compra
                Console.WriteLine("Jerarquía de ejecutivos es correcta!");

                //3 - Leer la información del pedido
                Pedido elPedido = new Pedido();
                bool valorPedidoCorrecto = false;

                do
                {
                    try
                    {
                        Console.Write("\nIngresa el valor del pedido: ");
                        elPedido.Valor = int.Parse(Console.ReadLine()!);
                        valorPedidoCorrecto = true;
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("El valor ingresado no es un dato numérico. Intenta nuevamente!");
                        Console.WriteLine(elError.Message);
                    }
                }
                while (valorPedidoCorrecto == false);

                //4 - Iniciar la cadena de aprobación según la jerarquía de ejecutivos
                JerarquiaEjecutivos[0].ProcesaPedido(elPedido);

                //5 - Visualizar resultados de la aprobación
                Console.WriteLine($"El resultado del proceso de validación es \n" +
                    $"{elPedido.Aprobador}");
            }
        }

        //Evalua si la jerarquia es válida para aprobar pedidos
        static bool EvaluaJerarquia(Ejecutivo[] losEjecutivos, out string mensajeError)
        {
            bool resultado = false;
            mensajeError = "";

            //aqui verificamos que tengan valores asignados diferentes a los predeterminados
            if (losEjecutivos[0].Monto > 0 && losEjecutivos[1].Monto > 0 && losEjecutivos[2].Monto > 0)
            {
                //aqui validamos que los valores estén escalonados de menor a mayor
                if (losEjecutivos[0].Monto < losEjecutivos[1].Monto && losEjecutivos[1].Monto < losEjecutivos[2].Monto)
                {                     
                    resultado = true;
                    mensajeError = "Jerarquia Válida";
                }
                else
                {
                    resultado = false;
                    mensajeError = "Montos no definen jerarquia de aprobación";
                }
            }
            else
            {
                resultado = false;
                mensajeError = "No se han asignado valores o los valores son negativos para los montos de los ejecutivos!";
            }

            return resultado;
        }

        static void AsignaValoresEjecutivo(Ejecutivo unEjecutivo)
        {
            bool datosCorrectos = false;

            do
            {
                try
                {
                    Console.Write($"\nIngresa el nombre del {unEjecutivo.Cargo}: ");
                    unEjecutivo.Nombre = Console.ReadLine();

                    Console.Write("Ingresa el monto máximo de aprobación: ");
                    unEjecutivo.Monto = int.Parse(Console.ReadLine()!);

                    datosCorrectos = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El monto ingresado no es un dato numérico. Intenta nuevamente!");
                    Console.WriteLine(elError.Message);
                }
            }
            while (datosCorrectos == false);
        }
    }
}
