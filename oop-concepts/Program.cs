using OOPAdventure;

Console.WriteLine("Hello what is your Name?");

var name = Console.ReadLine();

if (name == String.Empty) {
    name = "No Name";
}

var player = new Player(name);

Console.WriteLine("Welcome {0} to the oop Concepts ", player.Name);