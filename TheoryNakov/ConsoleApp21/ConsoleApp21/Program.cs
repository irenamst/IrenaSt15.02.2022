using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Card
    {
        public string Face { get; set; }
        public Suit Suit { get; set; }

        public override string ToString() =>
            "(" + this.Face +" "+ this.Suit + ")";
    }
    enum Suit
    {
        CLUB, DIAMOND, HEART, SPADE
    }
    
    internal class CardShuffle
    {
        static void Main(string[] args)
        {
            //Дефинираме лист и прибавяме карти в него с отделни команди
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "2", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "3", Suit = Suit.HEART });
            cards.Add(new Card() { Face = "4", Suit = Suit.SPADE });
            for(int i = 0; i < 2*cards.Count; i++)
            {
                PerformSingleSwap(cards);
                PrintCards(cards);
            }   
            
        }
        //метод за отпечатване на картите в тестето
        static void PrintCards(List<Card> cards) =>
            Console.WriteLine(String.Join("", cards));
        //метод за разбъркване на карти
        static void PerformSingleSwap(List<Card> cards)
        { 
            Random rand = new Random();
            int randomIndex=rand.Next(1, cards.Count);
            Card firstCard=cards[0];
            Card randomCard=cards[randomIndex];
            cards[0]= randomCard;
            cards[randomIndex] = firstCard;
        }
    }
}
