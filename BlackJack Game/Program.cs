namespace BlackJack_Game;
class Program
{
    static void Main(string[] args)
    {
        Player p1 = new Player("Tom", 10000);
        Console.WriteLine(p1.BreadCheck());
    }
}