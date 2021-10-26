using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(true);
            //deck.Shuffle();
            foreach (Card card in deck)
            {
                Console.WriteLine($"{card.Value} {card.Suit}");
            }

            Player Dave = new Player("Dave");
            deck.Deal(5, Dave);
            Console.WriteLine("================================================================");
            foreach (Card card in Dave.Hand)
            {
                Console.WriteLine($"{card.Value} {card.Suit}");
            }

            Player James = new Player("James");
            deck.Deal(5, James);
            Console.WriteLine("================================================================");
            foreach (Card card in James.Hand)
            {
                Console.WriteLine($"{card.Value} {card.Suit}");
            }
        }
    }
}
