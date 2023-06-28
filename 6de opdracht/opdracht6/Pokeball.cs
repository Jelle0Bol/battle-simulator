using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


sealed internal class Pokeball
{

    public Pokemon? pokemon;

    public void Capture(Pokemon pokemon)
    {
        this.pokemon = pokemon;
    }
    
     public void closes()
    {
        Console.WriteLine("pokeball closes");
    }
}

