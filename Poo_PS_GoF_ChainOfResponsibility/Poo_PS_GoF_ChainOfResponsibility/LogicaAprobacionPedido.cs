namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class LogicaAprobacionPedido
    {
        //Aqui van los atributos
        private Ejecutivo[] jerarquiaEjecutivos;
        private Pedido unPedido;

        //Aqui va el constructor de la clase
        public LogicaAprobacionPedido()
        {
            jerarquiaEjecutivos = new Ejecutivo[4];
            unPedido = new Pedido();
        }

        //Aqui va los métodos y propiedades
        public Ejecutivo[] LosEjecutivos
        {
            get { return jerarquiaEjecutivos; }
        }

        public Pedido UnPedido
        {
            get { return unPedido; }
            set { unPedido = value; }
        }

        public void InicializaJerarquiaEjecutivos()
        {
            jerarquiaEjecutivos[0] = new Coordinador();
            jerarquiaEjecutivos[1] = new Director();
            jerarquiaEjecutivos[2] = new Gerente();
            jerarquiaEjecutivos[3] = new Presidente();

            //Asignación de atributos para el coordinador
            jerarquiaEjecutivos[0].Nombre = "Bob";
            jerarquiaEjecutivos[0].Monto = 50000;
            jerarquiaEjecutivos[0].Jefe = jerarquiaEjecutivos[1];

            //Asignación de atributos para el director
            jerarquiaEjecutivos[1].Nombre = "Dora";
            jerarquiaEjecutivos[1].Monto = 500000;
            jerarquiaEjecutivos[1].Jefe = jerarquiaEjecutivos[2];

            //Asignación de atributos para el Gerente
            jerarquiaEjecutivos[2].Nombre = "Clemente";
            jerarquiaEjecutivos[2].Monto = 750000;
            jerarquiaEjecutivos[2].Jefe = jerarquiaEjecutivos[3];

            //Asignación de atributos para el Presidente
            jerarquiaEjecutivos[3].Nombre = "Vicente";
            jerarquiaEjecutivos[3].Monto = 5000000;
            jerarquiaEjecutivos[3].Jefe = null;
        }

        public void InicializaJerarquiaEjecutivos(Ejecutivo[] losEjecutivos)
        {
            jerarquiaEjecutivos = losEjecutivos;
        }

        public bool EvaluaJerarquia(out string mensajeError)
        {
            mensajeError = "";

            //Validar que solamente el último ejecutivo de la jerarquía sea el único sin jefe
            int contadorEjecutivosSinJefe = 0;
            for (int i = jerarquiaEjecutivos.Length - 1; i >= 0; i--)
            {
                if (jerarquiaEjecutivos[i].Jefe == null)
                    contadorEjecutivosSinJefe++;
            }

            //Si hay más de un ejecutivo sin jefe, hay error en la jerarquía
            if (contadorEjecutivosSinJefe > 1)
            {
                mensajeError = $"Hay {contadorEjecutivosSinJefe} ejecutivos sin jefe";
                return false;
            }

            if (jerarquiaEjecutivos[(jerarquiaEjecutivos.Length - 1)].Jefe != null)
            {
                mensajeError = $"El último ejecutivo en la jerarquía no es el único sin jefe";
                return false;
            }

            //Validar con un ciclo que los montos de los ejecutivos sean mayores que cero
            for (int i = 0; i < jerarquiaEjecutivos.Length; i++)
            {
                if (jerarquiaEjecutivos[i].Monto <= 0)
                {
                    mensajeError = $"El monto asingado para el ejecutivo {jerarquiaEjecutivos[i].Cargo} " +
                        $"- {jerarquiaEjecutivos[i].Nombre} no es mayor que cero";
                    return false;
                }
            }

            //Validar con un ciclo que los montos de los ejecutivos tengan jerarquía
            for (int i = 0; i < jerarquiaEjecutivos.Length - 1; i++)
            {
                if (jerarquiaEjecutivos[i].Monto >= jerarquiaEjecutivos[i + 1].Monto)
                {
                    mensajeError = $"El monto ${jerarquiaEjecutivos[i].Monto} del ejecutivo " +
                        $"{jerarquiaEjecutivos[i].Cargo} no es inferior al de {jerarquiaEjecutivos[i + 1].Cargo} " +
                        $"que tiene un monto de ${jerarquiaEjecutivos[i + 1].Monto}";
                    return false;
                }
            }

            //Si las validaciones funcionaron correctamente, se da el parte de confianza            
            mensajeError = "Todas las validaciones se ejecutaron correctamente";
            return true;
        }

        public string ProcesarPedido()
        {
            jerarquiaEjecutivos[0].ProcesaPedido(unPedido);
            return unPedido.Aprobador;
        }
    }
}
