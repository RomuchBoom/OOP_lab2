namespace GameClasses;

public class StandardGame : BasicGame
{
    public override void GameFeature()
    {
        Console.WriteLine("Rating must be positive");
        Console.WriteLine("All players gain or lose rating");        
    }

    public override void PlayGame(GameAccount Playa1, GameAccount Playa2, int rating)
    {
        if(rating < 0) 
        {
            throw new ArgumentOutOfRangeException(nameof(rating), "Game rating mustn't be negative or equal to zero");
        }

        this.GameRating = rating;

        string result = this.RandomResult(Playa1.UserName, Playa2.UserName);
        if(result == Playa1.UserName)
        {
            Playa1.WinGame(Playa2.UserName, this);
            Playa2.LoseGame(Playa1.UserName, this);
        }
        else
        {
            Playa2.WinGame(Playa1.UserName, this);
            Playa1.LoseGame(Playa2.UserName, this);
        }

        
    }

}