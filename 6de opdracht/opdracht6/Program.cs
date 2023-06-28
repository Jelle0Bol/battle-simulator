using System;
using System.Runtime.InteropServices;

namespace game
{ 
    class BattleSim
    {
        static void Main(string[] args)
        {
            
            string? answer = "";
            while (answer != "quit")
            {
                Console.Write("hoe wil je trainer noemen? : ");
                string? new_name1;
                new_name1 = Console.ReadLine();

                Console.Write("hoe wil je tweede trainer noemen? : ");
                string? new_name2;
                new_name2 = Console.ReadLine();
                Trainer trainer1 = new Trainer(new_name1);
                Trainer trainer2 = new Trainer(new_name2);
                
                Arena.Rounds(trainer1, trainer2);


                Console.WriteLine("");
                Console.Write("type quit to stop: ");
                answer = Console.ReadLine();
            }
        }
    }
}


