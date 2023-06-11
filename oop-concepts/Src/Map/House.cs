namespace OOPAdventure;

public partial class House 
{ 
    public Player Player { get; }
    
    private readonly Random _rnd = new (1234);

    //only constructer can set the player field, otherwise its a get field
    public House(Player player)
    {
        Player = player;
    }
}
