namespace BlackJack_Game;

internal class Player
{
    // properties

    private int Money { get; set; }
    
    private List<int> Cards { get; set; }
    
    // method
    
    public void SumofCards()
    {
        int total = 0;
        foreach (var card in Cards)
        { 
            total += card;
        }
        // Console.WriteLine(total);
    }
}