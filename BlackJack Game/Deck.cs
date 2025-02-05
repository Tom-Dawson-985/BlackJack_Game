using System.Security.Cryptography;

namespace BlackJack_Game;


public class Deck
{
    // constructor method
    public Deck()
    {
        
    }
    
    // Properties
    private int[] _FreshDeck = new int [52] {1,1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7,
        8,8,8,8,9,9,9,9,10,10,10,10,10,10,10,10,10,10,10,10,11,11,11,11};
    
    public int[] CurrentDeck = new int[52] {1,1,1,1,2,2,2,2,3,3,3,3,4,4,4,4,5,5,5,5,6,6,6,6,7,7,7,7,
        8,8,8,8,9,9,9,9,10,10,10,10,10,10,10,10,10,10,10,10,11,11,11,11};
    
    // methods
    public void ResetDeck()
    {
        CurrentDeck = _FreshDeck;
    }

    public void PrintDeck()
    {
        foreach (var card in CurrentDeck)
        {
            Console.Write($"{card} ");
        }
    }



}
