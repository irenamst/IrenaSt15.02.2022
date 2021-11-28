using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Card
    {
        public string Face { get; set; }
        public Suit Suit { get; set; }
        public override string ToString()=>
            "("+this.Face+" "+this.Suit+")";
    }
    enum Suit
    {
        CLUB,DIAMOND,HEART,SPADE
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            TestShuffle52Cards();  
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
                    Card card = new Card() { Face = face, Suit = suit };
                    cards.Add(card);
                }
            }
            ShuffleCards (cards);
            PrintCards(cards);
        }//end of TestShuffle52Cards()
        static void ShuffleCards(List<Card> cards)
        {
            Random rand = new Random();
            void PerformSingleSwap()
            {
                int randomIndex = rand.Next(1, cards.Count);
                Card firstCard = cards[0];
                Card randomCard = cards[randomIndex];
                cards[0] = randomCard;
                cards[randomIndex] = firstCard;
            }
            for(int i = 1; i <= cards.Count; i++)
            {
                PerformSingleSwap();
            }
        }//end of method ShuffleCards()
        static void PrintCards(List<Card> cards)
        {
            Console.WriteLine(String.Join("", cards));
        }
    }//end of the main method
}
