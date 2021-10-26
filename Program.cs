using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(true);
            deck.Shuffle();


            Player dave = new Player("Dave");
            Player james = new Player("James");
            deck.Deal(5, new Player[]{ dave, james });
            Console.WriteLine("================================================================");
            foreach (Card card in dave.Hand)
            {
                Console.WriteLine($"{card.Value} {card.Suit}");
            }

            Console.WriteLine("================================================================");
            foreach (Card card in james.Hand)
            {
                Console.WriteLine($"{card.Value} {card.Suit}");
            }
        }
    }
}
