namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class Presidente: Ejecutivo
    {
        public Presidente()
        {
            nombre = string.Empty;
            cargo = "Presidente";
            monto = 0;
            jefe = null;
        }

        public override void ProcesaPedido(Pedido laCompra)
        {
            //Si el valor del pedido es menor que el monto del Presidente
            //se puede aprobar el pedido
            if (laCompra.Valor <= monto)
                laCompra.Aprobador = $"Aprobado por {cargo} {nombre}";
            else
                laCompra.Aprobador = "El pedido debe aprobarse en Junta Directiva";
        }
    }
}
