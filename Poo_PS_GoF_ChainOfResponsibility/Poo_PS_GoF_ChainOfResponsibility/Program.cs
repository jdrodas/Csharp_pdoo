using System;

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

            //Asignación de atributos para el coordinador
            JerarquiaEjecutivos[0].Nombre = "Bob el Coordinador";
            JerarquiaEjecutivos[0].Monto = 50000;
            JerarquiaEjecutivos[0].Jefe = JerarquiaEjecutivos[1];

            //Asignación de atributos para el director
            JerarquiaEjecutivos[1].Nombre = "Dora la directora";
            JerarquiaEjecutivos[1].Monto = 500000;
            JerarquiaEjecutivos[1].Jefe = JerarquiaEjecutivos[2];

            //Asignación de atributos para el director
            JerarquiaEjecutivos[2].Nombre = "Vicente el Presidente";
            JerarquiaEjecutivos[2].Monto = 5000000;
            JerarquiaEjecutivos[2].Jefe = null;

            Console.WriteLine("\nLa jerarquía de cargos de la empresa es asi:");

            foreach (Ejecutivo unEjecutivo in JerarquiaEjecutivos)
                Console.WriteLine($"- {unEjecutivo.ToString()}");

            Console.WriteLine("\nValidamos la integridad de la jerarquía de ejecutivos...");

            string mensajeEvaluacion;
            bool resultadoEvaluacion = EvaluaJerarquia(JerarquiaEjecutivos, out mensajeEvaluacion);

            if (resultadoEvaluacion)
                Console.WriteLine($"Jerarquía válida. {mensajeEvaluacion}");
            else
                Console.WriteLine($"Jerarquía errónea. {mensajeEvaluacion}");

            //Aqui comenzamos a realizar pedidos y verificar quien los aprueba
            Pedido pedidoUno = new Pedido
                                    {
                                        Descripcion = "Palito de Queso Gluten Free con hilos de oro",
                                        Valor = 7500000
                                    };

            //Aqui le pasamos el pedido al ejecutivo más bajo en la cadena
            JerarquiaEjecutivos[0].ProcesaPedido(pedidoUno);

            Console.WriteLine($"\nSe intentó comprar {pedidoUno.Descripcion} " +
                $"con un valor de {pedidoUno.Valor} y el resultado de la compra fue: {pedidoUno.Aprobador}");
        }

        static bool EvaluaJerarquia(Ejecutivo[] losEjecutivos, out string mensajeError)
        {
            bool resultado = false;
            mensajeError = "";

            //TODO Validar con un ciclo que los montos de los ejecutivos sean mayores que cero

            //aqui verificamos que tengan valores asignados diferentes a los predeterminados
            if (losEjecutivos[0].Monto > 0 && losEjecutivos[1].Monto > 0 && losEjecutivos[2].Monto > 0)
            {
                //TODO Validar con un ciclo que los montos de los ejecutivos tengan jerarquía
                
                //aqui validamos que los valores estén escalonados de menor a mayor
                if (losEjecutivos[0].Monto < losEjecutivos[1].Monto && 
                    losEjecutivos[1].Monto < losEjecutivos[2].Monto)
                {
                    resultado = true;
                    mensajeError = "Todas las validaciones se ejecutaron correctamente";
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
    }
}
