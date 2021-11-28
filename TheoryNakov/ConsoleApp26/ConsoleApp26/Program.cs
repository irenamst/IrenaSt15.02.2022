using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{   
    class Card
    {
        public string Face { get; set; }
        public Suit Suit { get; set; }
        public override string ToString() => "(" + this.Face + " " + this.Suit + ")";
    }

    enum Suit
    {
        CLUB,DIAMOND,HEART,SPADE
    }
     class CardsShuffle
     {
        static Random rand = new Random();

        static void PerformSingleSwap(List<Card> cards,int i)
        {
            int randomIndex = rand.Next(1, cards.Count);
            Card firstCard = cards[i];
            Card randomCard = cards[randomIndex];
            cards[i] = randomCard;
            cards[randomIndex] = firstCard;
        }
        static void ShuffleCards(List<Card> cards)
        {
            if (cards.Count > 1)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    PerformSingleSwap(cards, i);
                }
            }
     
        }
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "2", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "3", Suit = Suit.HEART });
            cards.Add(new Card() { Face = "4", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "5", Suit = Suit.HEART });
            cards.Add(new Card() { Face = "6", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "7", Suit = Suit.SPADE });
            cards.Add(new Card() { Face = "8", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "9", Suit = Suit.DIAMOND });
            ShuffleCards(cards);
            PrintCards(cards);
            Console.WriteLine();
            TestShuffle52000Cards();
            Console.WriteLine();
            TestShuffle52Cards();
            
        }
        static void PrintCards(List<Card> cards) => Console.WriteLine(string.Join("", cards));

        static void TestShuffle52000Cards()
        {
            List<Card> cards = new List<Card>();
            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Suit[] allSuits = new Suit[] { Suit.CLUB, Suit.DIAMOND, Suit.HEART, Suit.SPADE };
            for(int i = 0; i < 1000; i++)
            {
                foreach (string face in allFaces)
            {
                foreach (Suit suit in allSuits)
                {
                    Card card = new Card()
                    {
                        Face = face,
                        Suit = suit
                    };
                    cards.Add(card);
                }
            }
            }
            DateTime oldTime = DateTime.Now;
            ShuffleCards(cards);
            DateTime newTime = DateTime.Now;
            
            PrintCards(cards);
            Console.WriteLine("Excecution time:{0}", newTime - oldTime);
        }

        static void TestShuffle52Cards()
        {
            List<Card> cards = new List<Card>();
            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Suit[] allSuits = new Suit[] { Suit.CLUB, Suit.DIAMOND, Suit.HEART, Suit.SPADE };
            foreach (string face in allFaces)
            {
                foreach (Suit suit in allSuits)
                {
                    Card card = new Card()
                    {
                        Face = face,
                        Suit = suit
                    };
                    cards.Add(card);
                }
            }
            DateTime oldTime = DateTime.Now;
            ShuffleCards(cards);
            DateTime newTime = DateTime.Now;
            
            PrintCards(cards);
            Console.WriteLine("Excecution time:{0}", newTime - oldTime);
        }
        static void TestShuffleOneCard()
        {
            List<Card> cards= new List<Card>();
            cards.Add(new Card() { Face = "A", Suit = Suit.CLUB });
            CardsShuffle.ShuffleCards(cards);
            CardsShuffle.PrintCards(cards);
        }
        static void TestShuffleTwoCards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "A", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "3", Suit = Suit.DIAMOND });
            CardsShuffle.ShuffleCards(cards);
            CardsShuffle.PrintCards(cards);
        }
    }
   
}
