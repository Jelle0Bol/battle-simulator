using game;
class Arena
{
    public static void Rounds(Trainer trainer1, Trainer trainer2 )
    {
        int x = 0;
        int[] scoreboard = { 0, 0 };
        int pokemon_trainer1 = 0;
        int pokemon_trainer2 = 0;
        while (pokemon_trainer1 < 6 && pokemon_trainer2 < 6)
        {
            Console.WriteLine("");
                Console.WriteLine("scoreboard : " + trainer1.Name + ": " + scoreboard[0] + " " + trainer2.Name + ": " + scoreboard[1]);
                x++;
                Console.WriteLine("Het is ronde " + x);
                Battle.Fight(trainer1, trainer2, scoreboard, ref pokemon_trainer1, ref pokemon_trainer2);

            
        }

        if (scoreboard[0] > scoreboard[1])
        {
            Console.Write(trainer1.Name + " won met " + scoreboard[0] + " punten");
        }
        else if (scoreboard[1] > scoreboard[0])
        {
            Console.Write(trainer2.Name + " won met " + scoreboard[1] + "punten");
        } else
        {
            Console.WriteLine("Niemand wint, het is gelijkspel!");
        }

    }


}
