using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ps_CadenaResponsabilidad
{
    class Director : Ejecutivo
    {
        public Director()
        {
            nombre = "Director sin nombre";
            monto = 0;
            jefe = null;
        }

        public override void ProcesaPedido(Pedido laCompra)
        {
            //Si el valor del pedido es menor que el monto del coordinador
            //se puede aprobar el pedido
            if (laCompra.Valor <= monto)
                laCompra.Aprobador = "Aprobado por Director " + nombre;
            else
                //Si hay jefe asignado, le pasamos el pedido para que lo apruebe
                if (jefe != null)
                    jefe.ProcesaPedido(laCompra);
                else
                    laCompra.Aprobador = "El director no tiene jefe. No se puede aprobar!";
        }
    }
}
