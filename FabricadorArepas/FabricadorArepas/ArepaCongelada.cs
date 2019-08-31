using System;

namespace FabricadorArepas
{
    class ArepaCongelada : Arepa, ICongelable
    {
        //Los atributos
        private int diasMaximosCongelado;

        //El constructor de la clase
        public ArepaCongelada() : base()
        {
            diasMaximosCongelado = 0;
        }

        public ArepaCongelada(int numeroMolino,
                            int diasCaducidad,
                            int diasMaximosCongelado) : base(diasCaducidad, numeroMolino)
        {
            this.diasMaximosCongelado = diasMaximosCongelado;
        }

        //Propiedades para los atributos
        public int DiasMaximosCongelado
        {
            get { return diasMaximosCongelado; }
            set { diasMaximosCongelado = value; }
        }

        public string InfoCongelacion()
        {
            string resultado = "Dias máximos de congelación: " + 
                diasMaximosCongelado + Environment.NewLine;
            return resultado;
        }

        public override string ObtieneInformacion()
        {
            string resultado = "Esta arepa fue congelada. " + Environment.NewLine +
                "La masa salió del molino " + numeroMolino + Environment.NewLine +
                "Tiene " + diasCaducidad + " dias de caducidad" + Environment.NewLine +
                InfoCongelacion();
            return resultado;
        }
    }
}
