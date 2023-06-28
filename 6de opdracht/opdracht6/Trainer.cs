using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Trainer
{
    private const int MaximumPokeballs = 6;
    private const int MaximumTypePokemon = 2;

    public Pokemon? pokemon;
    public string? Name;
    public List<Pokeball> belt;

    public Trainer(string? name)
    {
        Name = name;
        belt = new List<Pokeball>();

        for (int i = 0; i < MaximumPokeballs; i++)
        {
            belt.Add(new Pokeball());

            if (i < MaximumTypePokemon)
            {
                belt[i].Capture(new Charmander("sparky"));
            }
            else if (i >= MaximumTypePokemon && i < MaximumTypePokemon * 2)
            {
                belt[i].Capture(new Bulbasaur("bunger"));
            }
            else if (i >= MaximumTypePokemon * 2 && i < MaximumPokeballs)
            {
                belt[i].Capture(new Squirtle("pepe"));
            }
            else if (i >= MaximumPokeballs)
            {
                Console.WriteLine("There are too many pokeballs on your trainer's belt.");
            }
        }

        Random random = new Random();
        belt = belt.OrderBy(i => random.Next()).ToList();
    }

    public void ThrowBall(int number, Trainer trainer)
    {
        Console.WriteLine(trainer.Name + " sends out " + belt[number].pokemon?.name);
    }
}

