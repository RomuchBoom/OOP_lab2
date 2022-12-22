using GameClasses;


class lab2
{
    static void Main(string[] args)
    {
        var Player1 = new GameAccount("Vasya", 900, 4);
        var Player2 = new GameAccount("Petya", -450, 2);
        var Player3 = new GameAccount("Kolya", 200, 3);
        var game = new TrainingGame();
        //var game = new StandardGame();
        var game1 = new OnePlayerRatingGame();
        try
        {
            game.PlayGame(Player1, Player2);
            game1.PlayGame(Player1, Player3, 350);
        }
        catch(ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught creating a game with negative rating");
            Console.WriteLine(e.ToString());
            return;
        }

        Player1.GetStats();
        Console.WriteLine(Player1.CurrentRating);
        Player2.GetStats();
        Console.WriteLine(Player2.CurrentRating);
        Player3.GetStats();
        Console.WriteLine(Player3.CurrentRating);
    }
}
    