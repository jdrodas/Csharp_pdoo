using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_GoF_Observer
{
    public abstract class Divisa
    {
        //Atributos
        protected string? abreviatura;
        protected double valor;
        protected List<IInversionista> losInversionistas;

        public Divisa()
        {
            this.abreviatura = "";
            this.valor = 0;
            losInversionistas = new List<IInversionista>();
        }

        public void AsociarInversionista(IInversionista unInversionista)
        {
            losInversionistas.Add(unInversionista);
        }

        public void EliminarInversionista(IInversionista unInversionista)
        {
            losInversionistas.Remove(unInversionista);
        }

        public string? Abreviatura
        {
            get { return abreviatura; }
            set { abreviatura = value; }
        }

        public double Valor
        {
            get { return valor; }
            set 
            {
                if (valor != value)
                {
                    valor = value;
                    Notificar();
                }
            }
        }

        public void Notificar()
        {
            foreach (IInversionista unInversionista in losInversionistas)
            {
                unInversionista.Actualizar(this);
            }
        }
    }
}
