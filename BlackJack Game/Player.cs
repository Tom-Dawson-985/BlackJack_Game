namespace BlackJack_Game;
public class Player
{
    // constructor method
    public Player(string name, int startMoney) // each player gets a name and a starting amount of money
    {
        Money = startMoney;
        Name = name;
    }
    
    // properties
    /*
     List of all properties:
     - Name
     - Money
     - Players Cards
     - ****** Need to add current bet property *******
     - ****** Need to add win streak property *******
     */
    
    string Name {get; set;}// the name of the player

    private int Money { get; set; } // how much money the player has

    private HashSet<string> _playerCards = new HashSet<string>(); // the cards that the player has
    
    // methods
    
    public void SumofCards()// the total value of the players cards
    {
        int total = 0;
        foreach (string card in _playerCards)
        {
            if (card == "1" || card == "2" ||card == "3" ||card == "4" ||card == "5" ||card == "6" ||card == "7" ||card == "8" ||card == "9" ||card == "10")
            {
                total += Convert.ToInt32(card);
            }

            if (card == "J")
            {
                total += 10;
            }
            if (card == "Q")
            {
                total += 10;
            }
            if (card == "K")
            {
                total += 10;
            }
            if (card == "A")
            {
                if (total > 10)
                {
                    total++;
                }
                else
                {
                    total+= 11;
                }
            }
        }
    }

    public void NumberOfCards()
    {
        int total = 0;
        foreach (string card in _playerCards)
        {
            total ++;
        }
    }

    public void DrawCards() // take a card from the deck of cards
    {
        Random rng = new Random();

        int rand1 = rng.Next(1,12); // number between 1 and 12
    }

    public string BreadCheck() // how much money the player has left
    {
        return $"{this.Name} has {this.Money} left";
    }

    public int SetBet()
    {
        Console.WriteLine("Enter the amount you would like to bet: ");
        int betAmount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{this.Name} bets {betAmount}.");
        return betAmount;
        (this.Money) = (this.Money) - betAmount;
    }
}