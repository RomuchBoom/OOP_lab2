namespace GameClasses;

public class TrainingGame : BasicGame
{
    public override void GameFeature()
    {
       Console.WriteLine("Rating is equal to 0");
       Console.WriteLine("All players don't gain ot lose rating");
    }

    public override void PlayGame(GameAccount Playa1, GameAccount Playa2, int rating = 0)
    {
        if(rating != 0) 
        {
            throw new ArgumentOutOfRangeException(nameof(rating), "Game rating must be equal to zero");
        }

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