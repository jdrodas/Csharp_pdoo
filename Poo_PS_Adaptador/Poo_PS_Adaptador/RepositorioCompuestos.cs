
namespace Poo_PS_Adaptador
{
    //Esta es una clase "Adaptada"
    public class RepositorioCompuestos
    {
        public float ObtienePuntoCritico(string compuesto, string punto)
        {
            float valorPunto = 0f;

            // Punto congelación
            if (punto == "congelacion")
            {
                switch(compuesto.ToLower())
                {
                    case "agua":
                        valorPunto = 0f;
                        break;
                        
                    case "benzeno":
                        valorPunto = 5.5f;
                        break;

                    case "etanol":
                        valorPunto = -114f;
                        break;

                    case "cloruro de magnesio":
                        valorPunto = -15f;
                        break;

                    default:
                        valorPunto = 0f;
                        break;
                }
            }

            // Punto ebullicion
            if (punto == "ebullicion")
            {
                switch (compuesto.ToLower())
                {
                    case "agua":
                        valorPunto = 100f;
                        break;

                    case "benzeno":
                        valorPunto = 80f;
                        break;

                    case "etanol":
                        valorPunto = 78.3f;
                        break;

                    case "cloruro de magnesio":
                        valorPunto = 1412f;
                        break;

                    default:
                        valorPunto = 0f;
                        break;
                }
            }
            return valorPunto;
        }

        public string ObtieneFormulaQuimica(string compuesto)
        {
            switch (compuesto.ToLower())
            {
                case "agua": return "H20";
                case "benzeno": return "C6H6";
                case "etanol": return "C2H5OH";
                case "cloruro de magnesio": return "MgCl2";
                default: return "";
            }
        }

        public double ObtienePesoMolecular(string compuesto)
        {
            switch (compuesto.ToLower())
            {
                case "agua": return 18.015d;
                case "benzeno": return 78.1134d;
                case "etanol": return 46.0688d;
                case "cloruro de magnesio": return 95.211d;
                default: return 0d;
            }
        }
    }
}
