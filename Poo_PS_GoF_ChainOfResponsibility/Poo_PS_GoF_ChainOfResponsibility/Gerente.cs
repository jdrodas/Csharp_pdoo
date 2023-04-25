﻿namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class Gerente : Ejecutivo
    {
        public Gerente()
        {
            nombre = string.Empty;
            cargo = "Gerente";
            monto = 0;
            jefe = null;
        }

        public override void ProcesaPedido(Pedido laCompra)
        {
            //Si el valor del pedido es menor que el monto del director
            //se puede aprobar el pedido
            if (laCompra.Valor <= monto)
                laCompra.Aprobador = $"Aprobado por {cargo} {nombre}";
            else
                //Si hay jefe asignado, le pasamos el pedido para que lo apruebe
                if (jefe != null)
                jefe.ProcesaPedido(laCompra);
            else
                laCompra.Aprobador = "El gerente no tiene jefe. No se puede aprobar!";
        }
    }
}
