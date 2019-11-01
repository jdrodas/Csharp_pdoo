using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_CadenaResponsabilidad
{
    class ControlAprobacion
    {
        //Atributos de la clase
        private Ejecutivo elCoordinador, elDirector, elPresidente;
        private Pedido elPedido;
        private bool jerarquiaValidada;

        //Constructor de la clase
        public ControlAprobacion()
        {
            jerarquiaValidada = false;
            elPedido = new Pedido();

            elCoordinador = new Coordinador();
            elDirector = new Director();
            elPresidente = new Presidente();

            //aqui definimos la jerarquia... quien es jefe de quien
            elCoordinador.AsignaJefe(elDirector);
            elDirector.AsignaJefe(elPresidente);
        }

        public void AsignaValoresEjecutivo(string tipoEjecutivo, string nombre, int monto)
        {
            switch (tipoEjecutivo)
            {
                case "Coordinador":
                    elCoordinador.Nombre = nombre;
                    elCoordinador.Monto = monto;
                    break;

                case "Director":
                    elDirector.Nombre = nombre;
                    elDirector.Monto = monto;
                    break;

                case "Presidente":
                    elPresidente.Nombre = nombre;
                    elPresidente.Monto = monto;
                    break;
            }
        }

        //Evalua si la jerarquia es válida para aprobar pedidos
        public string EvaluaJerarquia()
        {
            string resultado="";

            //aqui verificamos que tengan valores asignados diferentes a los predeterminados
            if (elCoordinador.Monto > 0 && elDirector.Monto > 0 && elPresidente.Monto > 0)
            {
                //aqui validamos que los valores estén escalonados de menor a mayor
                if (elCoordinador.Monto < elDirector.Monto && elDirector.Monto < elPresidente.Monto)
                {
                    jerarquiaValidada = true;
                    resultado = "Jerarquía es correcta!";
                }
                else
                {
                    resultado = "Jerarquía inválida!";
                }
            }
            else
            {
                resultado = "No se han asignado valores o los valores son negativos para los montos de los ejecutivos!";
            }

            return resultado;
        }

        public string AutorizaPedido(int elValor)
        {
            string resultado = "";

            //Validamos si el pedido tiene un costo positivo
            if (elValor > 0)
            {
                //Validamos si la jerarquia está asignada correctamente
                if (jerarquiaValidada)
                {
                    elPedido.Valor = elValor;
                    //se le asigna al ejecutivo más bajo en la jerarquía
                    elCoordinador.ProcesaPedido(elPedido);
                    resultado = elPedido.Aprobador;
                }
                else
                {
                    resultado = "Jerarquía sin validar. No se puede aprobar todavía el pedido";
                }
            }
            else
            {
                resultado = "No se necesita autorización para un pedido gratuito! :-(";
            }

            return resultado;
        }

    }
}
