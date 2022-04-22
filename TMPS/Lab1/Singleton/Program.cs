using Singleton;

(new Thread(() =>
{
    var game2 = new Game();
    game2.Difficulty = Difficulty.getInstance("Hard");
    Console.WriteLine(game2.Difficulty.DiffLvl);
})).Start();

var game = new Game();
game.Difficulty = Difficulty.getInstance("Easy");
Console.WriteLine(game.Difficulty.DiffLvl);

var game3 = new Game();
game3.Difficulty = Difficulty.getInstance("Normal");
Console.WriteLine(game3.Difficulty.DiffLvl);