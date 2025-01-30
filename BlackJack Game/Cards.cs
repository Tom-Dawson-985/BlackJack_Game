using System.Security.Cryptography;

namespace BlackJack_Game;


public class Cards
{
<<<<<<< HEAD
    public int[] _cardSet =
    {
        1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10,
        10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10
    };


    private int[] _RoundCards = new int[_cardSet.Length];
=======
    // the deck that is used to restore the deck after each round
    string[] _freshDeck  = new string[] {"1","2","3","4","5","6","7","8","9","10","J","Q","K","A"};
    
    // the deck that is used when playing
    public HashSet<string> DeckOfCards = new HashSet<string>() {"1","2","3","4","5","6","7","8","9","10","J","Q","K","A"};

    public void NewGame() // triggered at the end of a round, adds all cards back to the deck
    {
        foreach (string card in DeckOfCards) // empty the set
        {
            DeckOfCards.Remove(card);
        }

        foreach (string card in _freshDeck) // restore the cards
        {
            DeckOfCards.Add(card);
        }
    }
>>>>>>> 9286a215b4121a1db5c934d74a2dc67327204165
}

