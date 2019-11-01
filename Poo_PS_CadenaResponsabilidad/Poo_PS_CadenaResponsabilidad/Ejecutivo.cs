using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_CadenaResponsabilidad
{
    abstract class Ejecutivo
    {
        //atributos de la clase
        protected string nombre;
        protected int monto;
        protected Ejecutivo jefe;

        //constructor de la clase
        public Ejecutivo()
        {
            nombre = "Ejecutivo sin nombre";
            monto = 0;
            jefe = null;
        }

        //Propiedades para los atributos
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public Ejecutivo Jefe
        {
            set { jefe = value; }
        }

        public void AsignaJefe(Ejecutivo jefe)
        {
            this.jefe = jefe;
        }

        public abstract void ProcesaPedido(Pedido laCompra);
    }
}
