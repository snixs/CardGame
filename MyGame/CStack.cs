using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

namespace WindowsApplication1
{
    class CStack
    {
        private Stack<Card> cardStack;
        private Card kozer;
        private Image trumpsuit;

        public CStack()
        {
            Card [] temp = new Card[36];
            int indx = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 6; j <= 14; j++)
                {
                    temp[indx] = new Card(i, j, null);
                    indx++;
                }
            }
            Random rnd = new Random();
            cardStack = new Stack<Card>();
            int h = rnd.Next(36);
            kozer = temp[h];
            switch (kozer.GetCardType())
            {
                case 1:
                    trumpsuit = Image.FromFile("" + 1 +".png");
                    break;

                case 2:
                    trumpsuit = Image.FromFile("" + 2 +".png");

                    break;

                case 3:
                    trumpsuit = Image.FromFile("" + 3 +".png");
                    break;

                case 4:
                    trumpsuit = Image.FromFile("" + 4 +".png");
                    break;
            }
            cardStack.Push(kozer);
            temp[h] = null;
            int count = 1;
            while (count <= 35)
            {
                h = rnd.Next(36);
                if (temp[h] != null)
                {
                    if (temp[h].GetCardType() == kozer.GetCardType())
                    {
                        temp[h].SetStatus(true);
                    }
                    cardStack.Push(temp[h]);
                    temp[h] = null;
                    count++;
                }
            }
        }

        public Card TakeCard()
        {
            if (cardStack.Count == 1)
            {
                return this.cardStack.Pop();
            }
            return this.cardStack.Pop();

        }
        public int GetCount()
        {
            return cardStack.Count;
        }
        public bool Is_empty()
        {
            if (this.cardStack.Count == 0)
                return true;
            else return false;
        }
        public int GetTrampSuit()
        {
            return kozer.GetCardType();
        }
        public void ShowDeck(Graphics g)
        {
            Rectangle rec = new Rectangle(600, 360, 70, 60);
            g.DrawImage(trumpsuit, rec);
            if (Is_empty() == false)
            {
                kozer.SetX(550);
                kozer.SetY(300);
                kozer.DrawKCard(g);
                for (int i = 0; i <= cardStack.Count - 2; i++)
                {
                    Card cr = cardStack.Peek();
                    cr.SetX(600 + i * 3);
                    cr.SetY(360);
                    cr.DrawOpCard(g);
                }
            }
        }
    }
}