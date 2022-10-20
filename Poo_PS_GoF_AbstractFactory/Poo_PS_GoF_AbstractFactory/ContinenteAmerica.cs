namespace Poo_PS_GoF_AbstractFactory
{
    public class ContinenteAmerica : Continente
    {
        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalTragon = new Chupacabras();
            return animalTragon;
        }

        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalTragado = new Cabra();
            return animalTragado;
        }
    }
}
