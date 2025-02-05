using System.Reflection.Metadata.Ecma335;

namespace BlackJack_Game;

public class Player
{
    // Constructor Variable
    public Player(string name)
    {
        PlayerName = name;
        TotalMoney = 100000;
        CurrentCards = new HashSet<int>();
    }

    // properties 
    public string PlayerName { get; set; }
    public int TotalMoney { get; set; }

    public HashSet<int> CurrentCards { get; set; }


    // methods
    public void PrintCards()
    {
        foreach (int i in CurrentCards!)
        {
            Console.Write($"{i} ");
        }
    }

    // return the total of the player cards
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