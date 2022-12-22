namespace GameClasses;

public class PremiumAccount : GameAccount
{
     public PremiumAccount(string UserName, int CurrentRating, int GamesCount) : base(UserName, CurrentRating, GamesCount)
    { 
       
    }
    public override void WinGame(string OpponentName, BasicGame game)
    {
        var currentGame = new GameStats(game.GameRating * 3/2, OpponentName, "Win");
        allGameStats.Add(currentGame);
        this.GamesCount++;   
    }

    public override void LoseGame(string OpponentName, BasicGame game)
    {
        var currentGame = new GameStats(game.GameRating / 2, OpponentName, "Lose");
        allGameStats.Add(currentGame);
        this.GamesCount++;   
    }
}