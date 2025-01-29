namespace BlackJack_Game;
public class Cards
{
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
}
