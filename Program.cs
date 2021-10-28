using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackJack game = new BlackJack();
            game.Play(new Player("Dave"));
        }
    }
}
