namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class Coordinador: Ejecutivo
    {
        public Coordinador()
        {
            nombre = "Coordinador sin nombre";
            cargo = "Coordinador";
            monto = 0;
            jefe = null;
        }

        public override void ProcesaPedido(Pedido laCompra)
        {
            //Si el valor del pedido es menor que el monto del coordinador
            //se puede aprobar el pedido
            if (laCompra.Valor <= monto)
                laCompra.Aprobador = $"Aprobado por Coordinador {nombre}";
            else
                //Si hay jefe asignado, le pasamos el pedido para que lo apruebe
                if (jefe != null)
                    jefe.ProcesaPedido(laCompra);
            else
                laCompra.Aprobador = "El coordinador no tiene jefe. No se puede aprobar!";
        }
    }
}
