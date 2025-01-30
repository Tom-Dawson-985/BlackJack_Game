
namespace BlackJack_Game;
using System;



 

class Program
{
    static void Main(string[] args)
    {
        Player p1 = new Player("Tom", 10000);
        Console.WriteLine(p1.BreadCheck());
        Console.WriteLine(p1.SetBet());
        Console.WriteLine(p1.BreadCheck());
        
        
        //Use this random for cards  
        Random rnd = new Random();

        Console.WriteLine(rnd.Next());       // Random integer
        Console.WriteLine(rnd.Next(1, 101)); // Random number between 1 and 100
        Console.WriteLine(rnd.NextDouble()); // Random double between 0.0 and 1.0    
    }
}