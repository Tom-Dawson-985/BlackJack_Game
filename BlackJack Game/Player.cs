using System.Reflection.Metadata.Ecma335;

namespace BlackJack_Game;

public class Player
{
    // constructor method
    public Player(string name, int startMoney) // each player gets a name and a starting amount of money
    {
        Money = startMoney;
        Name = name;
    }

    // Constructor Method =============================================================================================

    // Properties =====================================================================================================
    public int Money { get; set; }
    public string Name { get; set; }
    public List<int> PlayerCards { get; set; } = new List<int>();

    public int WinStreak { get; set; }
    // Methods ========================================================================================================
    /* methods that we need:
            - Bet
            - GetCard
            - BUST!!!!!
     */

    public int PlayerBet(int betAmount)
    {
        bool betWork = false;
        while (betWork == false)
        {
            if (betAmount > 0 && betAmount <= Money)
            {
                this.Money -= betAmount;
                betWork = true;
                return betAmount;
            }
            else if (betAmount > Money)
            {
                Console.WriteLine("FUCKKKK YOUUUUUU you big (poor, impoverished) fat bastard ");
            }
            else if (betAmount < 0)
            {
                Console.WriteLine("entere a real value u idiot");
            }

            
        }
        return 0;
    }
}