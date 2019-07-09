using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication1
{
    class CStack
    {
        private Stack<Card> cardStack;
        public CStack()
        {
            cardStack = new Stack<Card>();
        }

        public void PushCard(Card c)
        {
            this.cardStack.Push(c);
        }
        public Card PopCard()
        {
            return this.cardStack.Pop();
        }

        public void FillStack()
        {
            string[] cardNames;
            Random rnd = new Random();
            for (int i = 0; i <= 35; i++)
            {
            }
        }
    }
}
