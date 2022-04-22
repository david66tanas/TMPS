namespace Singleton
{
    public class Difficulty
    {
        private static Difficulty instance;

        private static object syncRoot = new Object();

        public string DiffLvl { get; private set; }

        public Difficulty(string diffLvl)
        {
            this.DiffLvl = diffLvl;
        }

        public static Difficulty getInstance(string difficultyLvl)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new Difficulty(difficultyLvl);
                }
            }
            return instance;
        }
    }
}