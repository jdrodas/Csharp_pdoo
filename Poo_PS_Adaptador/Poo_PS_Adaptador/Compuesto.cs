
namespace Poo_PS_Adaptador
{
    // Esta es la clase "Target"
    public class Compuesto
    {
        protected float puntoEbullicion;
        protected float puntoCongelacion;
        protected double pesoMolecular;
        protected string formulaQuimica;
        

        public virtual string InformacionCompuesto()
        {
            string informacion = "Este compuesto no tiene nada";
            return informacion;
        }
    }
}
