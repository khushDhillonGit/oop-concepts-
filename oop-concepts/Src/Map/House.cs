namespace OOPAdventure;

public partial class House 
{ 
    public Player Player { get; }
    
    private readonly Random _rnd = new (1234);

    public int Width { get; set; }
    public int Height { get; set; }
    public Room[] Rooms { get; set; }   

    //only constructer can set the player field, otherwise its a get field
    public House(Player player)
    {
        Player = player;
    }
}
