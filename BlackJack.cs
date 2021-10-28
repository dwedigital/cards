using System;
namespace cards
{
    class BlackJack
    {

        public static Deck Deck = new Deck();
        public static Player Dealer = new Player("Dealer");

        public double PlayerBet { get; private set; }

        public void Play(Player player)
        {


                Deck.Shuffle();
                Deck.Deal(1, player);
                Deck.Deal(2, Dealer);

                Console.WriteLine("\nPlace Bet");
                this.PlayerBet = Convert.ToDouble(Console.ReadLine());

                player.Display(true, 0);
                Dealer.Display(true, 0);

                int playerHandSum = 0;
                int dealerHandSum = 0;

                while (playerHandSum < 21)
                {
                    Console.WriteLine(" Sitck or hit?");

                    string stickHold = Console.ReadLine();

                    if (stickHold == "hit")
                    {
                        Deck.Deal(1, player);
                        player.Display(true, 1);
                    
                        foreach (Card card in player.Hand)
                        {
                            if (card.Value > 11)
                            {
                                playerHandSum += 10;
                            }
                            else
                            {
                                playerHandSum += card.Value;
                            }


                        }

                        if ((player.Hand[0].Value == 11 || player.Hand[1].Value == 11) && playerHandSum > 21)
                        {
                            playerHandSum -= 10;
                        }

                        foreach (Card card in Dealer.Hand)
                        {
                            if (card.Value > 11)
                            {
                                dealerHandSum += 10;
                            }
                            else
                            {
                                dealerHandSum += card.Value;
                            }


                        }
                        if ((Dealer.Hand[0].Value == 11 || Dealer.Hand[1].Value == 11) && dealerHandSum > 21)
                        {
                            dealerHandSum -= 10;
                        }
                    }

                    else{
                        if()
                    }


                        if (playerHandSum > 21)
                        {
                            Console.WriteLine("Dealer wins");
                            Dealer.Display(true, 1);
                            break;
                        }
                    Dealer.Display(true, 0);
                    Dealer.Display(true, 1);
                    if (dealerHandSum > 21 || (playerHandSum < 21 && dealerHandSum < playerHandSum))
                    {
                        Console.WriteLine("Player wins");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Dealer Wins");
                        break;
                    }
                }




            }
        }
    }
