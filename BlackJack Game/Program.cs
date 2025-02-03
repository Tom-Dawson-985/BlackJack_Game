
namespace BlackJack_Game;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message =============================================================================================
        
        Console.WriteLine("" +
        "\nThe Rules:  " +
        "\n1. Each player places a bet" +
        "\n2. The dealer gives each player 2 cards" +
        "\n3. The dealer gives themself one card that is revealed and one card that is hidden" +
        "\n4. player decide whether to hit or stand" +
        "\n\n\t(hit means a player gets another card)" +
        "\n\n\t(stand means the player keeps their current cards)" +
        "\n\n5. The dealer decides whether to hit" +
        "\n6. if the player total is more than 21 they have gone bust and lose " +
        "\n7. if the dealers hand goes over 21 all remaining players win" +
        "\n8. if neither the player nor the dealer busts, the highest total wins \n (scroll down)\n\n");
        
        bool playAgain = true; // Creates a Bool that will be used to end the game later                                                                                 
        
        // This sets up the First player Class, Giving it a name chosen by the user.

        Console.Write("Welcome to BlackJack! \n Enter your Name: ");        // ask for inputs
            string playername = Console.ReadLine();                         // Reads the input and stores as playername                                                 
                Player p1 = new Player(playername, 10000);        // Creates a Player Class
        
        // EXPLANATION
        // - If a new players name is entered a while loop will begin
        // - The while repeats the adding process, so as many players as needed can be added
        // - for every new player the play counter will increase by 1
        // - the player counter will be used later to iterate through sequences in each round
        
        int numberOfPlayers = 1; // This is the player counter
        
        Console.WriteLine($"\nHello, {playername}!" +
                          $"\n To add another player input their name below (you can add up to 4 players." + // asks the user to add any other players
                          $"\n To play alone just press 'ENTER'" +
                          $"/n INPUT HERE: ");
        string newPlayerName = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(newPlayerName)) // if the input is not empty start the loop                                                   // if the player enters anything
        {
            while (!string.IsNullOrWhiteSpace(newPlayerName)) // every time a name is given
            {
                string formattedName = $"p{numberOfPlayers}"; // creates a p1, p2, p3 name for the new player
                numberOfPlayers++; // adds a new player to counter
                
                Player [numberOfPlayers] = new Player(newPlayerName, 10000); // creates a player called p2 (then p3 etc)
                

                
                // now that the new player has been made we need to ask for a new one

                Console.WriteLine($"Hello{newPlayerName}!" + // says hello to the NEW player
                                  $"\nTo add another player input their name below." +
                                  $"\nTo play with the current players just press 'ENTER'" +
                                  $"\nINPUT HERE: ");
                newPlayerName = Console.ReadLine(); // resets the newPlayerName so that either a new player or a continue is added
            } 
            Console.WriteLine("You just pressed 'ENTER'! " +
                              "\nTime to Play!");   
        }
        else                                                                                                            // if the play just hits enter
        {
            Console.WriteLine("You just pressed 'ENTER'! " +
                              "\nTime to Play!\n\n");                                                // A new round starts
        }
        
        
        // create game function here while (Play_Again)
        
        /*
        while (playAgain == true)                                                                                       // If end game isn't selected a new round will begin
        {
            
            Console.WriteLine();
        }
        */
        
        
        
        
        // Example bet process ========================================================================
        Console.WriteLine($"You have {p1.Money} \n Enter Your Bet amount:");
        int tempBet = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(p1.PlayerBet(tempBet));
        
        
        
        
    }
}