using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_GoF_Observer
{
    internal class Inversionista : IInversionista
    {
        private string? nombre;
        private Divisa? divisa;

        public Inversionista(string nombre)
        {
            this.nombre = nombre;               
        }

        public Divisa? Divisa
        { 
            get { return divisa; }
            set { divisa = value; }
        }

        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void Actualizar(Divisa unaDivisa)
        {
            string informacion = $"El inversionista {nombre} " +
                $"ha sido notificado que la divisa {unaDivisa.Abreviatura} " +
                $"tiene precio de {unaDivisa.Valor}\n";


            Console.WriteLine(informacion);
        }
    }
}
