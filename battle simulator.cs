using System;

class Charmander
{
    private string name;
    private int fireStrength;
    private string waterWeakness;

    public Charmander(string name, int fireStrength, string waterWeakness)
    {
        this.name = name;
        this.fireStrength = fireStrength;
        this.waterWeakness = waterWeakness;
    }

    public void BattleCry()
    {
        Console.WriteLine(name + "!");
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

            Console.WriteLine("Enter a name for Charmander: ");
            string charmanderName = Console.ReadLine();

            Charmander charmander = new Charmander(charmanderName, 10, "Water");

            Console.WriteLine($"Charmander's name: {charmanderName}");

            for (int i = 0; i < 10; i++)
            {
                charmander.BattleCry();
            }

            Console.WriteLine("Enter a new name for Charmander or 'q' to quit: ");
            string newName = Console.ReadLine();

            if (newName == "q")
            {
                quitGame = true;
                Console.WriteLine("Quitting the game...");
            }
            else
            {
                charmanderName = newName;
                charmander = new Charmander(charmanderName, 10, "Water");

                Console.WriteLine($"Charmander's name updated to: {charmanderName}");

                for (int i = 0; i < 10; i++)
                {
                    charmander.BattleCry();
                }
            }
        }
    }
}
