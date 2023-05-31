class Pokeball
{

    public Charmander? charmander;


    public void addPokemon()
    {
        Charmander charmander = new Charmander("sparky", "water", "fire");
        this.charmander = charmander;
    }
    public void open()
    {
        if (charmander != null)
        {
            charmander.battleCry();
        }
    }

}