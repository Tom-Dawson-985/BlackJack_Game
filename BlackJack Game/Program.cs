
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
        NewGameAndFirstRound();

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
            player.TotalMoney -=playerBet;
            Console.WriteLine($"You have lost {playerBet}, you have {player.TotalMoney} left");
        }
        
        void NewGameAndFirstRound()
        {
            
            // get the player bet
            Console.Write($"{player.PlayerName}, you have {player.TotalMoney}, Enter your bet for the next round: ");
            int playerBet = Convert.ToInt32(Console.ReadLine());
            
            PlayerDrawsCards();
            PlayerDrawsCards();
            DealerDrawsCards();
            DealerDrawsCards();
            
            
            if (dealer.GetCardTotal() == 21)
            {
                DealerBj();
            }
            
            Console.WriteLine($"{player.PlayerName} your total is : {player.GetCardTotal()}\nThe dealers total is: {dealer.GetCardTotal()}");
            Console.WriteLine("Enter 1 to hit\nEnter 2 to stand\nEnter 3 to Double");
            int playerInput = Convert.ToInt32(Console.ReadLine());
            if (playerInput == 1)
            {
                PlayerDrawsCards();
                Console.WriteLine($"Your total is: {player.GetCardTotal()}");
            }

            if (playerInput == 3 &&  playerBet*2 < player.TotalMoney)
            {
                playerBet  = playerBet * 2;
                PlayerDrawsCards();
                Console.WriteLine($"Your total is: {player.GetCardTotal()}");
                
            }
            else if (playerInput == 3)
            {
                Console.WriteLine("You cant afford to double, instead hit");
                PlayerDrawsCards();
                Console.WriteLine($"Your total is: {player.GetCardTotal()}");
            }
            
            if (dealer.dealerlog() == 1)
            {
                DealerDrawsCards();
                dealer.GetCardTotal();

            }

            if 
            {
            }
                
        }

        void CheckWinner()
        {
            if (player.GetCardTotal() > dealer.GetCardTotal() && player.GetCardTotal() < 21 && (dealer.GetCardTotal() > 21))
            {
                Console.WriteLine($"You won {playerBet * 2}");
                player.TotalMoney += playerBet * 2;
                Console.WriteLine($"You now have: {player.TotalMoney}");
            }

            if (dealer.GetCardTotal() > 21 && (player.GetCardTotal() > 21))
            {
                Console.WriteLine($"You won {playerBet * 2}");
            }
            
        }
        
    }
}