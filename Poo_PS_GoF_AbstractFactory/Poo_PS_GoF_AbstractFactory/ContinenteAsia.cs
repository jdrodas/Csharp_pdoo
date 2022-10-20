namespace Poo_PS_GoF_AbstractFactory
{
    public class ContinenteAsia : Continente
    {
        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalTragon = new Tigre();
            return animalTragon;
        }

        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalTragado = new Vaca();
            return animalTragado;
        }
    }
}
