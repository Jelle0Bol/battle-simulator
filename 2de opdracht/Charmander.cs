class Charmander
{
    string? name;
    string strength, weakness = "";
    public Charmander(string? name, string weakness, string strength)
    {
        this.name = name;
        this.weakness = weakness;
        this.strength = strength;
    }
    public void battleCry()
    {
        Console.WriteLine(this.name + " used battle cry: " + this.name + "!");
    }
}