namespace GameClasses;

public class OnePlayerRatingGame : BasicGame
{
    public override void GameFeature()
    {
        Console.WriteLine("Rating must be positive");
        Console.WriteLine("Only one player gain or lose rating");
    }

    public override void PlayGame(GameAccount RatingPlaya, GameAccount NonRatingPlaya, int rating)
    {
        if(rating <= 0) 
        {
            throw new ArgumentOutOfRangeException(nameof(rating), "Game rating mustn't be negative or equal to zero");
        }

        string result = this.RandomResult(RatingPlaya.UserName, NonRatingPlaya.UserName);
        if(result == RatingPlaya.UserName)
        {
            NonRatingPlaya.LoseGame(RatingPlaya.UserName, this);
            this.GameRating = rating;
            RatingPlaya.WinGame(NonRatingPlaya.UserName, this);
            
        }
        else
        {
            NonRatingPlaya.WinGame(RatingPlaya.UserName, this);
            this.GameRating = rating;
            RatingPlaya.LoseGame(NonRatingPlaya.UserName, this);
            
        }
    }

}