namespace Singleton
{
    public class Game
    {
        public Difficulty Difficulty { get; set; }

        public void Launch(string difficultyLvl)
        {
            Difficulty = Difficulty.getInstance(difficultyLvl);
        }
    }
}