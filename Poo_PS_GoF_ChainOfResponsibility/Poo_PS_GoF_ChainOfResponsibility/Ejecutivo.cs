
namespace Poo_PS_GoF_ChainOfResponsibility
{
    public abstract class Ejecutivo
    {
        //atributos de la clase
        protected string? nombre;
        protected string? cargo;
        protected int monto;
        protected Ejecutivo? jefe;

        //constructor de la clase
        public Ejecutivo()
        {
            nombre = string.Empty;
            cargo = string.Empty;
            monto = 0;
            jefe = null;
        }

        //Propiedades para los atributos
        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string? Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public int Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public Ejecutivo? Jefe
        {
            set { jefe = value; }
            get { return jefe; }
        }

        public abstract void ProcesaPedido(Pedido laCompra);

        public override string ToString()
        {
            string informacion = $"{nombre} es {cargo} y puede aprobar hasta {monto}\n";
            if (jefe != null) 
                informacion += $"\tel jefe es {jefe.Nombre}";
            else
                informacion += $"\tNo tiene jefe asignado";

            return informacion;
        }
    }
}
