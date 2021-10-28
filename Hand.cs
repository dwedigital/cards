using System.Collections;
using System.Collections.Generic;

namespace cards
{

    class Hand : IEnumerator, IEnumerable
    {
        public List<Card> Cards { get; private set; }
        public int Count { get; private set; }
        int position = -1;

        public Hand(List<Card> cards)
        {
            this.Cards = cards;
            this.Count = cards.Count;
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

        public void Display(int number)
        {
            for (int i = 0; i < number; i++)
            {
                System.Console.WriteLine($"{Cards[i].Value} {Cards[i].Suit}");
            }
        }
    }
}