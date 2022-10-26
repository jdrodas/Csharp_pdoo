namespace Poo_PS_GoF_Facade
{
    public class Cliente
    { 
    
        //Atributos de la clase
        private string? nombre;
        private int puntajeDataCredito;
        private string? reputacionCredito;
        private float montoMaximo, valorPrestamo, valorCesantias;
        private bool estadoSolicitud;

        //constructor de la clase
        public Cliente()
        {
            nombre = "";
            valorPrestamo = 0f;
            valorCesantias = 0f;
            puntajeDataCredito = 0;
            reputacionCredito = "D";
            montoMaximo = 0f;
            estadoSolicitud = false;
        }

    public Cliente(string nombre, float valorPrestamo,
        float valorCesantias, int puntajeDataCredito)
    {
        this.nombre = nombre;
        this.valorPrestamo = valorPrestamo;
        this.valorCesantias = valorCesantias;
        this.puntajeDataCredito = puntajeDataCredito;
        this.reputacionCredito = "D";
        this.montoMaximo = 0f;
        this.estadoSolicitud = false;
    }

    //propiedades para los atributos
    public string? Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public float ValorPrestamo
    {
        get { return valorPrestamo; }
        set
        {
            if (value > 0)
                valorPrestamo = value;
            else
                valorPrestamo = 0;
        }
    }
    public float ValorCesantias
    {
        get { return valorCesantias; }
        set
        {
            if (value > 0)
                valorCesantias = value;
            else
                valorCesantias = 0;
        }
    }
    public int PuntajeDataCredito
    {
        get { return puntajeDataCredito; }
        set
        {
            if (value > 0)
                puntajeDataCredito = value;
            else
                puntajeDataCredito = 0;
        }
    }
    public bool EstadoSolicitud
    {
        get { return estadoSolicitud; }
        set { estadoSolicitud = value; }
    }
    public float MontoMaximo
    {
        get { return montoMaximo; }
        set
        {
            if (value > 0)
                montoMaximo = value;
            else
                montoMaximo = 0;
        }
    }
    public string? ReputacionCredito
    {
        get { return reputacionCredito; }
        set
        {
            if (value == "A" || value == "B" || value == "C" || value == "D")
                reputacionCredito = value;
            else
                reputacionCredito = "D";
        }
    }
}
}