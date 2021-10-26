using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(true);
            deck.Shuffle();


            Player Dave = new Player("Dave");
            Player James = new Player("James");
            deck.Deal(5, new Player[]{ Dave, James });
            Console.WriteLine("================================================================");
            foreach (Card card in Dave.Hand)
            {
                Console.WriteLine($"{card.Value} {card.Suit}");
            }

            Console.WriteLine("================================================================");
            foreach (Card card in James.Hand)
            {
                Console.WriteLine($"{card.Value} {card.Suit}");
            }
        }
    }
}
