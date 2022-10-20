using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Adaptador
{
    public class CompuestoEnriquecido:Compuesto
    {
        private string nombre;
        private RepositorioCompuestos dbCompuestos;

        //Constructor de la clase
        public CompuestoEnriquecido(string nombre)
        {
            this.nombre = nombre;
            dbCompuestos = new RepositorioCompuestos();
        }

        public override string InformacionCompuesto()
        {
            //Obtener la información desde la base de datos
            puntoEbullicion = dbCompuestos.ObtienePuntoCritico(nombre, "ebullicion");
            puntoCongelacion = dbCompuestos.ObtienePuntoCritico(nombre, "congelacion");
            pesoMolecular = dbCompuestos.ObtienePesoMolecular(nombre);
            formulaQuimica = dbCompuestos.ObtieneFormulaQuimica(nombre);

            string informacion = $"Compuesto: {nombre}\n" +
                $"Peso molecular: {pesoMolecular}\n" +
                $"Fórmula química: {formulaQuimica}\n" +
                $"punto ebullición: {puntoEbullicion}\n" +
                $"punto congelación: {puntoCongelacion}";

            return informacion;
        }

    }
}
