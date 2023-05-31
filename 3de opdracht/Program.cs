using System;

namespace game
{ 
    class BattleSim
    {
        static void Main(string[] args)
        {

            string? answer = "";
            while (answer != "stop")
            {
                Console.Write("hoe wil je je eerste trainer noemen? : ");
                string? new_name1;
                new_name1 = Console.ReadLine();

                Console.Write("hoe wil je je tweede trainer noemen? : ");
                string? new_name2;
                new_name2 = Console.ReadLine();
                Trainer trainer1 = new Trainer(new_name1);
                Trainer trainer2 = new Trainer(new_name2);
                for (int x = 0; x < 6; x++)
                {
                    
                    trainer1.ThrowBall(x, trainer1);
                    trainer1.belt[x].pokemon?.battleCry();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    trainer2.ThrowBall(x, trainer2);
                    trainer2.belt[x].pokemon?.battleCry();
                    Console.WriteLine("");
                    Console.WriteLine(trainer1 + " neemt terug " + trainer1.belt[x].pokemon?.name);
                    trainer1.belt[x].closes();
                    Console.WriteLine(trainer2 + " neemt terug " + trainer2.belt[x].pokemon?.name);
                    trainer2.belt[x].closes();
                    Console.WriteLine("");





                    //trainer1.ThrowBall(x, trainer2);
                }
                Console.Write("typ stop om het programmatje af te sluiten : ");
                answer = Console.ReadLine();
            }
        }
    }
}


