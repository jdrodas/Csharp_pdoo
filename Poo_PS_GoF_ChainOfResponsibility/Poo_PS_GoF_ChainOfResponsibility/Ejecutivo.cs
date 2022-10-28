
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
            nombre = "Ejecutivo sin cargo";
            cargo = "Ejecutivo";
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
        }

        public int Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public void AsignaJefe(Ejecutivo jefe)
        {
            this.jefe = jefe;
        }

        public abstract void ProcesaPedido(Pedido laCompra);
    }
}
