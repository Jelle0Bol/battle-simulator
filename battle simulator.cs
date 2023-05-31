using System;
using System.Collections.Generic;

class Charmander
{
    private string name;

    public Charmander(string name)
    {
        this.name = name;
    }

    public void BattleCry()
    {
        Console.WriteLine(name + "!");
    }
}

class Pokeball
{
    private bool isOpen;
    private Charmander charmander;

    public Pokeball()
    {
        isOpen = false;
        charmander = null;
    }

    public bool IsOpen
    {
        get { return isOpen; }
    }

    public Charmander Charmander
    {
        get { return charmander; }
    }

    public void Throw(Charmander charmander)
    {
        if (!isOpen)
        {
            this.charmander = charmander;
            isOpen = true;
            Console.WriteLine("Pokeball thrown!");
            charmander.BattleCry();
        }
        else
        {
            Console.WriteLine("Pokeball is already open.");
        }
    }

    public void Return()
    {
        if (isOpen)
        {
            isOpen = false;
            Console.WriteLine("Charmander returned to the pokeball.");
        }
        else
        {
            Console.WriteLine("Pokeball is already closed.");
        }
    }
}

class Trainer
{
    private string name;
    private List<Pokeball> belt;

    public Trainer(string name)
    {
        this.name = name;
        belt = new List<Pokeball>();

        // Initialize the belt with six pokeballs, each containing a Charmander
        for (int i = 0; i < 6; i++)
        {
            belt.Add(new Pokeball());
        }
    }

    public string Name
    {
        get { return name; }
    }

    public List<Pokeball> Belt
    {
        get { return belt; }
    }

    public void ThrowPokeball(int index)
    {
        if (index >= 0 && index < belt.Count)
        {
            Pokeball pokeball = belt[index];

            if (!pokeball.IsOpen)
            {
                Charmander charmander = new Charmander(name + "'s Charmander " + (index + 1));
                pokeball.Throw(charmander);
            }
            else
            {
                Console.WriteLine("Pokeball is already open.");
            }
        }
        else
        {
            Console.WriteLine("Invalid pokeball index.");
        }
    }

    public void ReturnCharmander(int index)
    {
        if (index >= 0 && index < belt.Count)
        {
            Pokeball pokeball = belt[index];

            if (pokeball.IsOpen)
            {
                pokeball.Return();
            }
            else
            {
                Console.WriteLine("Pokeball is already closed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid pokeball index.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pokemon Battle Simulator");

        bool quitGame = false;

        while (!quitGame)
        {
            Console.WriteLine("Starting the game...");

            Console.WriteLine("Enter the name of the first trainer: ");
            string trainer1Name = Console.ReadLine();
            Trainer trainer1 = new Trainer(trainer1Name);

            Console.WriteLine("Enter the name of the second trainer: ");
            string trainer2Name = Console.ReadLine();
            Trainer trainer2 = new Trainer(trainer2Name);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{trainer1.Name} throws Pokeball {i + 1}");
                trainer1.ThrowPokeball(i);

                Console.WriteLine($"{trainer2.Name} throws Pokeball {i + 1}");
                trainer2.ThrowPokeball(i);

                Console.WriteLine($"{trainer1.Name} returns Charmander {i + 1}");
                trainer1.ReturnCharmander(i);

                Console.WriteLine($"{trainer2.Name} returns Charmander {i + 1}");
                trainer2.ReturnCharmander(i);
            }

            Console.WriteLine("Do you want to play again? (y/n)");
            string playAgain = Console.ReadLine();

            if (playAgain != "y")
            {
                quitGame = true;
                Console.WriteLine("Quitting the game...");
            }
        }
    }
}
