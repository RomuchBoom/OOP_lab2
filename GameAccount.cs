using System;
namespace GameClasses;


public class GameAccount
{
    public string UserName { get; set; }
    public int BaseRating { get; set; }
    public int CurrentRating
    {
        get
        {
            int val = 0;
            foreach(var elem in allGameStats)
            {
                val += elem.GameRating;
            }
            return (val + BaseRating);
        }
        /*set
        {
            CurrentRating = value;
        }*/
    }
    public int GamesCount { get; set; }
    public List<GameStats> allGameStats = new List<GameStats>(); 

    public GameAccount(string UserName, int BaseRating, int GamesCount)
    {
        this.UserName = UserName;
        this.BaseRating = Math.Max(1, BaseRating);
        this.GamesCount = GamesCount;
    }

    public virtual void WinGame(string OpponentName, BasicGame game)
    {
        var currentGame = new GameStats(game.GameRating, OpponentName, "Win");
        allGameStats.Add(currentGame);
        this.GamesCount++;   
    }
    

    public virtual void LoseGame(string OpponentName, BasicGame game)
    {
        var currentGame = new GameStats(-game.GameRating, OpponentName, "Lose");
        allGameStats.Add(currentGame);
        this.GamesCount++;
    }

    public void GetStats()
    {
        Console.WriteLine($"\n--- {this.UserName}'s account game history:\n");
        Console.WriteLine("////////////////////");
        foreach(var elem in allGameStats)
        {
            Console.WriteLine($"\nOpponent Name: {elem.OpponentName}");
            Console.WriteLine($"Game Result: {elem.GameResult}");
            Console.WriteLine($"Game rating: {elem.GameRating}");
            Console.WriteLine($"Game ID: {elem.GameID}\n");
            Console.WriteLine("////////////////////");
        }
    }

}