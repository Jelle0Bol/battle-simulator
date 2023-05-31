using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Trainer
{
    public Pokemon pokemon;
    public string? Name;
    public List<Pokeball> belt;
    public Trainer(string? Name)
    {
        this.Name = Name;
        belt = new List<Pokeball>();

        for (int i = 0; i < 6; i++)
        {
            belt.Add(new Pokeball());
            
            if (i < 2)
            {
                belt[i].Capture(new Charmander("sparky"));
            }
            else if (i == 2 || i == 3 )
            {
                belt[i].Capture(new Bulbasaur("bunger"));


            }
            else if (i == 4 || i == 5)
            {
                belt[i].Capture(new Squirtle("pepe"));

            }
        }
    }
    public void ThrowBall(int number, Trainer trainer)
    {
        Console.WriteLine(trainer.Name + " stuurt uit " + belt[number].pokemon?.name);
        //belt[number].OpenBall();

    }

}

