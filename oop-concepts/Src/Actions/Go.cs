namespace OOPAdventure;

public class Go: Action
{
    //just a readonly property
    public override string Name => Text.Language.Go;

    private readonly House _house;

    public Go(House house) { 
        _house = house;
    }

    public override void Execute(string[] args)
    {
        var currentRoom = _house.CurrentRoom;

        var dir = args[1].Substring(0,1).ToUpper() + args[1].Substring(1).ToLower();

        Enum.TryParse(dir, out Directions newDirction);

        var nextRoomIndex = currentRoom.Neighbors[newDirction];

        if (nextRoomIndex == -1 || newDirction.Equals(Directions.None))
            Console.WriteLine(Text.Language.GoError);
        else
            _house.GoToRoom(nextRoomIndex);




    }



}