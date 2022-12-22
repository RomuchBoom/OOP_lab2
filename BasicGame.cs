namespace GameClasses;

public abstract class BasicGame
{
    public abstract void GameFeature();

    public int GameRating = 0;
    public string RandomResult(string Player1, string Player2)
    {
        Random random = new Random();
        int result = random.Next(0, 100);
        if(result % 2 == 0) return Player2;
        return Player1;
    }

    public abstract void PlayGame(GameAccount Winna, GameAccount Loosa, int rating);


}
