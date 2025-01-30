
namespace BlackJack_Game;
using System;



 

class Program
{
    static void Main(string[] args)
    {
        
        bool Play_Again = true;
        Console.WriteLine("Welcome to BlackJack! \n what is player 1s name");
        string playername = Console.ReadLine();
        Player p1 = new Player(playername, 10000);
        
        
        // this is checking if there is a player 2 if so it gets their name and creates a new player
        Console.WriteLine($"Hello{playername} is there a player 2 please enter their name if not press enter  ");
        string Player2Name = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(Player2Name))
        {
            Console.WriteLine($"Hello{playername} \n its time to play the game");
            Player p2 = new Player(Player2Name, 10000);
        }
        else
        {
            Console.WriteLine("You just pressed Enter! \n lets play");
        }
        
        
        Console.WriteLine(p1.BreadCheck());
        Console.WriteLine(p1.SetBet());
        Console.WriteLine(p1.BreadCheck());
        
        
        //Use this random for cards  
        Random rnd = new Random();

        Console.WriteLine(rnd.Next());       // Random integer
        Console.WriteLine(rnd.Next(1, 101)); // Random number between 1 and 100
        Console.WriteLine(rnd.NextDouble()); // Random double between 0.0 and 1.0    
        
        
        while (Play_Again = true)
        {
            // play game in here 
            Console.WriteLine();
        }
    }
}