namespace Poo_PS_GoF_AbstractFactory
{
    public class ContinenteOceania : Continente
    {
        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalTragado = new Koala();
            return animalTragado;
        }

        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalTragon = new Dingo();
            return animalTragon;
        }
    }
}
