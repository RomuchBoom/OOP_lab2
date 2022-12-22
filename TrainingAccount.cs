namespace GameClasses;

public class TrainingAccount : GameAccount
{
    public TrainingAccount(string UserName, int CurrentRating, int GamesCount) : base(UserName, CurrentRating, GamesCount)
    { 
       
    }

    public override void WinGame(string OpponentName, BasicGame game)
    {
        var currentGame = new GameStats(0, OpponentName, "Win");
        allGameStats.Add(currentGame);
        this.GamesCount++;   
    }

    public override void LoseGame(string OpponentName, BasicGame game)
    {
        var currentGame = new GameStats(0, OpponentName, "Lose");
        allGameStats.Add(currentGame);
        this.GamesCount++;   
    }
}