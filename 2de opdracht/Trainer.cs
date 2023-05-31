class Trainer
{
    public string? Name;
    public List<Pokeball> belt;

    public Trainer(string? Name)
    {
        this.Name = Name;
        belt = new List<Pokeball>();

        for (int i = 0; i < 6; i++)
        {
            belt.Add(new Pokeball());
        }
    }
}