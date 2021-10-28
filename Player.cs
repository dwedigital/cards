using System.Collections.Generic;
namespace cards{

    class Player{
        public string Name { get; private set;}
        public List<Card> Hand { get; set; } = new List<Card>();

        public Player(string name){
            this.Name = name;
        }

                public void Display(bool cardIndex = false, int index = 0)
        {
            if(cardIndex){
                System.Console.WriteLine($"{Hand[index].Value} {Hand[index].Suit}");
            }else{
                foreach(Card card in Hand){
                    System.Console.WriteLine($"{card.Value} {card.Suit}");
                }
            }
        }

    }
}