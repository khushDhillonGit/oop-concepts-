namespace OOPAdventure;

public class English : Language {
    public English()
    {
        ChooseYourName = "Hello what is your Name?";
        DefaultName = "No Name";
        Welcome = "Welcome {0} to the oop Concepts!";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = "You are in a room with doors to the {0}.";
    }
}