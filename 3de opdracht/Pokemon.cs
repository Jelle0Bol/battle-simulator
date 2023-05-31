using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


abstract class Pokemon
{
 
 
    public string name, strength, weakness;
    public Pokemon(string name, string strength, string weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;

    }
    public abstract void battleCry();        
}

class Charmander: Pokemon
{
   public Charmander(string name):base(name,"fire", "water")
    {
        this.name = name;
    }
    public override void battleCry()
    {
        Console.WriteLine(this.name + " gebruikt battle cry: Charmander!");
    }
}
class Bulbasaur : Pokemon
{
    public Bulbasaur(string name) : base(name, "leaf", "fire")
    {
        this.name = name;
    }
    public override void battleCry()
    {
        Console.WriteLine(this.name + " gebruikt battle cry: Bulba!");
    }
}
class Squirtle : Pokemon
{
    public Squirtle(string name) : base(name, "water", "leaf")
    {
        this.name = name;
    }
    public override void battleCry()
    {
        Console.WriteLine(this.name + " gebruikt battle cry: Squirtle!");
    }
}