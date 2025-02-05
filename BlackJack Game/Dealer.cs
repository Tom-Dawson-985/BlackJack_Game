namespace BlackJack_Game;
public class Dealer
{
    // constructor method
    public Dealer()
    {
        CurrentCards = new HashSet<int>();
    }
    
    // properties
    public HashSet<int> CurrentCards { get; set; }
    
    // Methods
    public void PrintCards()
    {
        foreach (int i in CurrentCards!)
        {
            Console.Write($"{i} ");
        }
    }

    public int ReturnCardTotal()
    {
        int total = 0;
        // Looping through the HashSet using foreach
        foreach (int number in CurrentCards)
        {
            Console.WriteLine(number);
        }
        return total;
    }
    
    public void DrawCard(int cardFromDeck)
    {
        CurrentCards.Add(cardFromDeck);
    }

    public int GetCardTotal()
    {
        int cardTotal = 0;
        foreach (int card in CurrentCards)
        {
            if (card == 11)
            {
                cardTotal++;
            }
            else
            {
                cardTotal += card;
            }
        }
        return cardTotal;
    }
}