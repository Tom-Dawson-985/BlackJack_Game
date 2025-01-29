namespace BlackJack_Game;
public class Player
{
    // constructor method
    public Player(string name, int startMoney) 
    {
        Money = startMoney;
        Name = name;
    }
    
    // properties
    string Name {get; set;}

    private int Money { get; set; }

    private HashSet<string> _playerCards = new HashSet<string>();
    
    // methods
    
    public void SumofCards()
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
        // Console.WriteLine(total);
    }

    public void NumberOfCards()
    {
        int total = 0;
        foreach (string card in _playerCards)
        {
            total ++;
        }
    }

    public void DrawCards()
    {
        Random rng = new Random();

        int rand1 = rng.Next(1,12); // number between 1 and 12
    }

    public string BreadCheck()
    {
        return $"{this.Name} has {this.Money} left";
    }
}