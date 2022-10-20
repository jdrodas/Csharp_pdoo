namespace Poo_PS_GoF_AbstractFactory
{
    public class ContinenteAfrica : Continente
    {
        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalTragon = new Gacela();
            return animalTragon;
        }

        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalTragado = new Leon();
            return animalTragado;
        }
    }
}
