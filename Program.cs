using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){

            BlackJack game = new BlackJack();
            game.Play(new Player("Dave"));
            }
        }
    }
}
