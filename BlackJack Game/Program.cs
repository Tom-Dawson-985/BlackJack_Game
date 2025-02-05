
namespace BlackJack_Game;
using System;

class Program
{
    static void Main(string[] args)
    {
        // create all the objects
        Player player = new Player("Tom");
        
        Dealer dealer = new Dealer();
        Deck deck = new Deck();
        // create all variables
        int playerBet = 0;
        
        // welcome
        Console.WriteLine($"Welcome to Blackjack {player.PlayerName}");
        NewGame();

        void PlayerDrawsCards()
        {
            Random rnd = new Random();
            int cardNumber = rnd.Next(0, 51);
            
            while (deck.CurrentDeck[cardNumber] == 0)
            {
                player.CurrentCards.Add(deck.CurrentDeck[cardNumber]);
                deck.CurrentDeck[cardNumber] = 0;
            }
            player.CurrentCards.Add(deck.CurrentDeck[cardNumber]);
            deck.CurrentDeck[cardNumber] = 0;
        }

        void DealerDrawsCards()
        {
            Random rnd = new Random();
            int cardNumber = rnd.Next(0, 51);
            
            while (deck.CurrentDeck[cardNumber] == 0)
            {
                dealer.CurrentCards.Add(deck.CurrentDeck[cardNumber]);
                deck.CurrentDeck[cardNumber] = 0;
            }
            dealer.CurrentCards.Add(deck.CurrentDeck[cardNumber]);
            deck.CurrentDeck[cardNumber] = 0;
        }
        
        void DealerBj()
        {
            Console.WriteLine("Dealer has BlackJack");
            Console.WriteLine($"You have lost {playerBet}, you have {player.TotalMoney} left");
            // new game starts
            NewGame();
        } // ✅

        void PlayerHit()
        {
            PlayerDrawsCards();
            // check win
            if (player.GetCardTotal() > 21)
            {
                player.PlayerStand = true;
            }
        }

        void PlayerDouble()
        {
            if (player.TotalMoney > playerBet)
            {
                playerBet = playerBet * 2;
                player.TotalMoney -= playerBet;
                PlayerDrawsCards();
            }
            else
            {
                Console.WriteLine("You do not have enough money to double instead hit:");
                PlayerHit();
            }
        }

        void DealerLogic()
        {

            while (dealer.GetCardTotal() < 17)
            {
                DealerDrawsCards();
                Console.WriteLine("Dealer Draws a card");
            }
            CheckWinner();
        }
        
        void CheckWinner()
        {
            if (player.GetCardTotal() > dealer.GetCardTotal() && player.GetCardTotal() < 21 && (dealer.GetCardTotal() < 21))
            {
                Console.WriteLine($"You won {playerBet}");
                player.TotalMoney += playerBet * 2;
                Console.WriteLine($"You now have: {player.TotalMoney}");
            }
            if (dealer.GetCardTotal() > 21 && (player.GetCardTotal() <= 21))
            {
                Console.WriteLine($"Dealer has gone bust, you won {playerBet}");
                player.TotalMoney += playerBet * 2;
                Console.WriteLine($"You now have: {player.TotalMoney}");
            }
            if (player.GetCardTotal() > 21 && dealer.GetCardTotal() <= 21)
            {
                Console.WriteLine($"You have gone bust, you have lost{playerBet}");
            }
            if (player.GetCardTotal() > 21 && dealer.GetCardTotal() <= 21)
            {
                Console.WriteLine($"You and the Dealer have gone bust you get {playerBet} back");
                player.TotalMoney += playerBet;
            }
            //player.Clearatron3000();
            //dealer.Clearatron3000();
            NewGame();
        }
        
        void NewGame()
        {
            
            // get the player bet
            Console.Write($"{player.PlayerName}, you have {player.TotalMoney}, Enter your bet for the next round: ");
            int playerBet = Convert.ToInt32(Console.ReadLine()); // ✅
            player.TotalMoney -= playerBet;
            
            PlayerDrawsCards(); // deal the cards ✅
            PlayerDrawsCards();
            DealerDrawsCards();
            DealerDrawsCards();
            
            
            if (dealer.GetCardTotal() == 21) // ✅
            {
                DealerBj(); // player loses and new game starts 🚨
            }

            while (player.PlayerStand == false)
            {
                Console.WriteLine($"{player.PlayerName} your total is : {player.GetCardTotal()}\nThe dealers total is: {dealer.GetCardTotal()}");
                Console.WriteLine("Enter 1 to hit\nEnter 2 to stand\nEnter 3 to Double");// ✅
                int playerInput = Convert.ToInt32(Console.ReadLine());
                
                if (playerInput == 1)
                {
                    PlayerHit();
                }
                
                if (playerInput == 3)
                {
                    PlayerDouble();
                    player.PlayerStand = true;
                }

                if (playerInput == 2)
                {
                    
                    CheckWinner();
                    player.PlayerStand = true;
                }
                CheckWinner();
            }
            DealerLogic();
            
                
        }

        
        
    }
}