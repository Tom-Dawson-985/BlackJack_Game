
namespace BlackJack_Game;
using System;



 

class Program
{
    static void Main(string[] args)
    {
        
        bool Play_Again = true;                                                                                         // bool so roudns can be iterated
        Console.WriteLine("Welcome to BlackJack! \n what is player 1s name");                                           // just asks
        string playername = Console.ReadLine();                                                                         // reads the answer
        Player p1 = new Player(playername, 10000);                                                            // makes a new Player class
        
        
        // this is checking if there is a player 2 if so it gets their name and creates a new player
        Console.WriteLine($"Hello{playername} is there a player 2 please enter their name if not press enter  ");       // checks for player 2
        string Player2Name = Console.ReadLine();                                                                        // asks for input
        
        if (!string.IsNullOrWhiteSpace(Player2Name))                                                                    // if the player enters anything
        {
            Console.WriteLine($"Hello{playername} \n its time to play the game");                                       // Game starts and message is displayed
            Player p2 = new Player(Player2Name, 10000);                                                       // new player class is created and initialised
        }
        else                                                                                                            // if the play just hits enter
        {
            Console.WriteLine("You just pressed Enter! \n lets play");                                                  // A new round starts
        }
        
        
        // create game function here while (Play_Again)
        
        
        while (Play_Again == true)                                                                                      // If end game isn't selected a new round will begin
        {
            
            Console.WriteLine();
        }
    }
}