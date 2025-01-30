using System.Security.Cryptography;

namespace BlackJack_Game;


public class Cards
{
    // Constructor Method =============================================================================================
    
    
    // Properties =====================================================================================================
    
    private int[] _cardSet = new int[] {1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7,
        7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 11, 11, 11, 11};
    
    // Methods ========================================================================================================
    public int GetCard()                        // Method to take a card from the deck and give it to player or dealer
    {
        Random rnd = new Random();              // Internal class to get random number
        int cardNumber = rnd.Next(0, 51);       // ^^^
        
        int pos = cardNumber;
        int Card = _cardSet[pos];        // Saves the card Value as 
        
        
        
        return Card;

    }
    
    
    //public void NewGame() // triggered at the end of a round, adds all cards back to the deck
    //{
      //  foreach (string card in DeckOfCards) // empty the set
        //{
          //  DeckOfCards.Remove(card);
        //}

       // foreach (string card in _freshDeck) // restore the cards
        //{
          //  DeckOfCards.Add(card);
        //}
    //}
}


