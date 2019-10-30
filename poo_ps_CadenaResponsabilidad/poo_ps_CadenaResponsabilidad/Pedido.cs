using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_ps_CadenaResponsabilidad
{
    class Pedido
    {
        //atributos de la clase
        private string aprobador;
        private int valor;

        //constructor de la clase
        public Pedido()
        {
            aprobador = "sin aprobación";
            valor = 0;
        }

        //Propiedades para los atributos
        public string Aprobador
        {
            get { return aprobador; }
            set { aprobador = value; }
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
