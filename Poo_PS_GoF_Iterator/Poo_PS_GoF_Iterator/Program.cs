namespace Poo_PS_GoF_Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Patrón GoF - Iterador");
            Console.WriteLine("Album de láminas\n\n");

            // Construimos una colección
            Album miAlbum = new Album();
            miAlbum[0] = new Lamina(1,"Equipo - Francia");
            miAlbum[1] = new Lamina(2,"Jugador - Leonel Messi");
            miAlbum[2] = new Lamina(3,"Equipo - Brasil");
            miAlbum[3] = new Lamina(4,"Jugador - Cristiano Ronaldo");
            miAlbum[4] = new Lamina(5,"Equipo - Inglaterra");
            miAlbum[5] = new Lamina(6,"Equipo - Japón");
            miAlbum[6] = new Lamina(7,"Jugador - Neymar");
            miAlbum[7] = new Lamina(8,"Equipo - Holanda");
            miAlbum[8] = new Lamina(9,"Equipo - Mexico");
            miAlbum.Nombre = "Mundial 2022";

            // Creamos el iterador
            Iterador unInterador = miAlbum.CrearIterador();
            
            unInterador.Incremento = 1;
            
            Console.WriteLine($"Iterando sobre el album: {miAlbum.Nombre}");
            for (Lamina unaLamina = unInterador.Primera();
                !unInterador.EstaTerminado; 
                unaLamina = unInterador.Siguiente())
            {
                Console.WriteLine(unaLamina.ToString());
            }
        }
    }
}