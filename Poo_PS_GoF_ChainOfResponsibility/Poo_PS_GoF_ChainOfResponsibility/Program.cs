using System;

namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patrón GoF - Cadena de Responsabilidad");
            Console.WriteLine("Aprobación de Pedidos");

            LogicaAprobacionPedido laLogica = new LogicaAprobacionPedido();

            //1 - Definir nombres y montos de la jerarquía de ejecutivos
            Console.WriteLine("\n *** Definición de la jerarquía de ejecutivos");
            laLogica.InicializaJerarquiaEjecutivos();
            
            Console.WriteLine("\nLa jerarquía de cargos de la empresa es asi:");

            foreach (Ejecutivo unEjecutivo in laLogica.LosEjecutivos)
                Console.WriteLine($"- {unEjecutivo.ToString()}");

            Console.WriteLine("\nValidamos la integridad de la jerarquía de ejecutivos...");

            string mensajeEvaluacion;
            bool resultadoEvaluacion = laLogica.EvaluaJerarquia(out mensajeEvaluacion);

            if (resultadoEvaluacion == false)
            {
                Console.WriteLine($"Jerarquía errónea. {mensajeEvaluacion}");
                Console.WriteLine($"No se puede aprobar pedidos hasta que no se solucione la jerarquía de ejecutivos");
            }
            else
            {
                Console.WriteLine($"Jerarquía válida. {mensajeEvaluacion}");
                //Aqui comenzamos a realizar pedidos y verificar quien los aprueba
                Pedido pedidoUno = new Pedido
                {
                    Descripcion = "Palito de Queso Gluten Free con hilos de oro",
                    Valor = 4500000
                };

                laLogica.UnPedido = pedidoUno;
                string resultadoAprobacion = laLogica.ProcesarPedido();

                Console.WriteLine($"\nSe intentó comprar: \n{pedidoUno.Descripcion} " +
                    $"con un valor de {pedidoUno.Valor}. " +
                    $"\nEl resultado de la compra fue: {resultadoAprobacion}");
            }
        }
    }
}
