using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace cards
{
    class Deck : IEnumerator, IEnumerable
    {
        public List<Card> Cards = new List<Card>();
        int position = -1;

        public Deck(bool aceHigh = true)
        {
            string[] suits = new string[] { "♠", "♥", "♦", "♣" };
            foreach (string suit in suits)
            {
                for (int i = (aceHigh ? 2 : 1); i <= (aceHigh ? 14 : 13); i++)
                {
                    Cards.Add(new Card(suit, i));
                }
            }
        }

        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < Cards.Count);
        }
        //IEnumerable
        public void Reset()
        {
            position = -1;
        }
        //IEnumerable
        public object Current
        {
            get { return Cards[position]; }
        }

        public int Count()
        {
            return Cards.Count;
        }
        public void Shuffle()
        {
            System.Random rnd = new System.Random();
            Cards = Cards.OrderBy(item => rnd.Next()).ToList();
        }

        public void Deal(int numberCards, Player[] players){

            foreach (Player player in players){

            List<Card> hand = new List<Card>();

            for(int i = 0; i < numberCards; i++){
                hand.Add(Cards[i]);
                Cards.RemoveAt(i);

            }
            player.Hand = new Hand(hand);
        }
        }
    }
}