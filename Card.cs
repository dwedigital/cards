namespace cards{
    class Card{
        public string Suit {get; private set;}
        public int Value {get; private set;}

        public  Card(string suit, int value){
            this.Suit = suit;
            this.Value = value;
        }
    }
}