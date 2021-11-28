using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    //създаване на namespace брез клас
    class Card{
        public string Face { get; set; }
        public Suit Suit { get; set; }
        public override string ToString()=>
            "("+this.Face+" "+this.Suit+")";
    }
    //изброяване в списък като namespace
    enum Suit
    {
        CLUB,DIAMOND,HEART,SPADE
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "2", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "6", Suit = Suit.DIAMOND });
            cards.Add(new Card() { Face = "7", Suit = Suit.HEART });
            cards.Add(new Card() { Face = "A", Suit = Suit.SPADE });
            cards.Add(new Card() { Face = "J", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "10", Suit = Suit.DIAMOND });
            Console.Write("Intial desk: ");
            PrintCards(cards);
            ShuffleCards(cards);
            Console.Write("After shuffle: ");
            PrintCards(cards);
        }
        //метод за извеждане
        static void PrintCards(List<Card> cards)
        {
            Console.WriteLine(String.Join(", ",cards));
        }
        //метод за единично разместване
        static void PerformSingleSwap(List<Card> cards)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(1, cards.Count);

            //дефинираме картите, които ще разместваме
            Card firstCard=cards[0];
            Card randomCard = cards[randomIndex];

            //разместваме картите
            cards[0] = randomCard;
            cards[randomIndex] = firstCard;
        }
        //метод за разбъркване
        static void ShuffleCards(List<Card> cards)
        {
            for(int i=1; i < cards.Count; i++)
            {
                PerformSingleSwap(cards);
                PrintCards(cards);
            }
        }
    }
}
