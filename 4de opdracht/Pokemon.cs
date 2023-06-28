using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


public enum Type
{
    Fire,
    Water,
    Leaf
}

abstract class Pokemon
{
    public string name;
    public Type strength;
    public Type weakness;

    public Pokemon(string name, Type strength, Type weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract void BattleCry();
}
class Charmander : Pokemon
{
    public Charmander(string name) : base(name, Type.Fire, Type.Water) { }

    public override void BattleCry()
    {
        Console.WriteLine(name + " gebruikt battle cry: Charmander!");
    }
}

class Bulbasaur : Pokemon
{
    public Bulbasaur(string name) : base(name, Type.Leaf, Type.Fire) { }

    public override void BattleCry()
    {
        Console.WriteLine(name + " gebruikt battle cry: Bulba!");
    }
}

class Squirtle : Pokemon
{
    public Squirtle(string name) : base(name, Type.Water, Type.Leaf) { }

    public override void BattleCry()
    {
        Console.WriteLine(name + " gebruikt battle cry: Squirtle!");
    }
}