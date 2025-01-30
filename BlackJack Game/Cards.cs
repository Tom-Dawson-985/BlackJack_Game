using System.Security.Cryptography;

namespace BlackJack_Game;


public class Cards
{

    public int[] _cardSet =
    {
        1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10,
        10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10
    };

    public void GetCard()
    {
        Random rnd = new Random();
        int CardNumber = rnd.Next(1, 101);
        
        int Card = _cardSet[CardNumber];

        

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


