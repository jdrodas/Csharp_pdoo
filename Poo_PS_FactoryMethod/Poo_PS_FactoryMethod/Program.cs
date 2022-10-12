using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular el comportamiento de una Editorial");
            Console.WriteLine("Utilizando el patrón de software GoF - Factory Method");

            Documento[] losDocumentos = new Documento[2];

            losDocumentos[0] = new DocumentoHojaDeVida() { Nombre = "Hoja de Vida de Cientifico"};
            losDocumentos[1] = new DocumentoLibro() { Nombre = "Libro de autor decepcionante!"};


            int contadorPaginas = 0;
            Pagina unaPagina;
            Console.WriteLine("\nLos documentos en nuestra colección son:");
            foreach (Documento unDocumento in losDocumentos)
            {
                Console.WriteLine($"\nDocumento: {unDocumento.Nombre}");

                //Recorrer la lista de páginas utilizando un ciclo for
                for (contadorPaginas = 0; contadorPaginas < unDocumento.LasPaginas.Count; contadorPaginas++)
                {
                    unaPagina = unDocumento.LasPaginas.ElementAt(contadorPaginas);
                    Console.WriteLine($"\t*** {unaPagina.Titulo}\n\t{unaPagina.Informacion()}");
                }

                //Recorrer la lista de páginas utilizando un ciclo while
                //contadorPaginas = 0;
                //while (contadorPaginas < unDocumento.LasPaginas.Count)
                //{
                //    unaPagina = unDocumento.LasPaginas.ElementAt(contadorPaginas);
                //    Console.WriteLine($"\t*** {unaPagina.Titulo}\n\t{unaPagina.Informacion()}");
                //    contadorPaginas++;
                //}

                //Recorrer la lista de paginas utilizando un ciclo Foreach
                //foreach (Pagina unaPagina in unDocumento.LasPaginas)
                //{
                //    Console.WriteLine($"\t*** {unaPagina.Titulo}\n\t{unaPagina.Informacion()}");
                //}
            }
        }
    }
}
