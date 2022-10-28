using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class Presidente: Ejecutivo
    {
        public Presidente()
        {
            nombre = "Presidente sin nombre";
            cargo = "Presidente";
            monto = 0;
            jefe = null;
        }

        public override void ProcesaPedido(Pedido laCompra)
        {
            //Si el valor del pedido es menor que el monto del coordinador
            //se puede aprobar el pedido
            if (laCompra.Valor <= monto)
                laCompra.Aprobador = $"Aprobado por Presidente {nombre}";
            else
                laCompra.Aprobador = "El pedido debe aprobarse en Junta Directiva";
        }
    }
}
