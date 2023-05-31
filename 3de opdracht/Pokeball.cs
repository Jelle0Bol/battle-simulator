using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Pokeball
{

    public Pokemon? pokemon;

    public void Capture(Pokemon pokemon)
    {
        this.pokemon = pokemon;
    }
    //public void OpenBall()
      // {
      //     pokemon.battleCry();
     //}
     public void closes()
    {
        Console.WriteLine("Pokeball gaat dicht");
    }
}

