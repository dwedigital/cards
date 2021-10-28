using System;
namespace cards{
    class BlackJack{

        public static Deck Deck = new Deck();
        public static  Player Dealer = new Player("Dealer");

        public double PlayerBet {get;private set;}

        public void Play(Player player){

            Console.WriteLine("Place Bet");
            this.PlayerBet = Convert.ToDouble(Console.ReadLine());

            Deck.Shuffle();
            Deck.Deal(1, new[]{player});
            Deck.Deal(2, new[]{Dealer});
            player.Hand.Display(1);
            Dealer.Hand.Display(1);

            Console.WriteLine(" Sitck or hit?");

            string stickHold = Console.ReadLine();

            if(stickHold == "hit"){
                Deck.Deal(1, new[]{player});
                player.Hand.Display(2);
            }
            Console.WriteLine("Dealer holds:\n");
            Dealer.Hand.Display(2);

            
            
        }
    }
}