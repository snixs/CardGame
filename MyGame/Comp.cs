using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

namespace WindowsApplication1
{
    class Comp
    {
        public List<Card> hand;
        int posy = 55;
        private int count;

        public Comp(CStack cs)
        {
            hand = new List<Card>();
            for (int i = 1; i < 7; i++)
            {
                Card cr = cs.TakeCard();
                InsertCard(cr);
            }
        }
        public void DrawHand(Graphics g)
        {
            for (int i = 0; i <= hand.Count - 1; i++)
            {
               hand[i].DrawOpCard(g);
               // hand[i].DrawCard(g);
            }
        }
        public void InsertCard(Card cr)
        {
            cr.SetY(posy);
            if (this.count == 0)
            {
                cr.SetX(100);
            }
            else
            {
                if (count <= 4)
                {
                    cr.SetX(hand[count - 1].GetX() + 76);
                }
                else
                {
                    int i = 0;
                    while (i <= count - 2)
                    {
                        hand[i + 1].SetX(hand[i].GetX() + 40 / count + 65);
                        i++;
                    }
                    cr.SetX(hand[i].GetX() + 40 / count + 65);
                }

            }
            hand.Add(cr);
            count++;
        }
        public void RemoveCard(int indx)
        {
            hand.Remove(hand[indx]);
            int j = indx;
            if (indx <= count - 1)
            {
                if (count <= 6)
                {
                    while (j <= count - 2)
                    {
                        hand[j].SetX(hand[j].GetX() - 76);
                        j++;
                    }
                }
                else
                {
                    while (j <= count - 2)
                    {
                        hand[j].SetX(hand[j].GetX() - 60);
                        j++;
                    }
                }
            }
           
            count--;
        }
        public void Draw6(CStack dek)
        {
            while(count <6)
            {
                InsertCard(dek.TakeCard());
            }
        }
        public void Defend(Table arena)
        {
            Card temp = new Card(0, 0, null);
            int card = 0;
            Card cr = null;
            bool ans = false;
            bool present= true;
            while (arena.GetANCount() < arena.GetCount() && present == true)
            {
                while(card <= count-1 && ans==false)
                {
                    if (arena.DCheck(hand[card]) && hand[card].GetStatus() == false)
                    {
                         cr = hand[card];
                         arena.AddAnsCard(cr, arena.GetANCount());
                         RemoveCard(card);
                         ans = true;
                    }
                    card++;
                 }
                 card = 0;
                 while (card <= count - 1 && ans == false)
                 {
                     if (arena.DCheck(hand[card]))
                     {
                         cr = hand[card];
                         arena.AddAnsCard(cr, arena.GetANCount());
                         RemoveCard(card);
                         ans = true;
                     }
                     card++;
                 }

                 if (ans == false)
                 {
                     present = false;
                 }
             }
        }
        public void Atack(Table arena)
        {
            int i = 0;
            Card cr = null;
            int ans = 16;
            int indx = 0;
            for (i = 0; i <= count - 1; i++)
            {
                if (arena.ACheck(hand[i]) && hand[i].GetStatus() == false)
                {
                    if (hand[i].GetNum() <= ans)
                    {
                        cr = hand[i];
                        indx = i;
                        ans = hand[i].GetNum();
                    }
                }
            }
            if (cr == null)
            {
                for (i = 0; i <= count - 1; i++)
                {
                    if (arena.ACheck(hand[i]))
                    {
                        if (hand[i].GetNum() <= ans)
                        {
                            cr = hand[i];
                            indx = i;
                            ans = hand[i].GetNum();
                        }
                    }
                }
            }
            if (cr != null)
            {
                RemoveCard(indx);
                arena.AddCard(cr);
            }
        }
        public void Take(Table tab)
        {
            Card cr = null;
            while (tab.GetCount() != 0)
            {
                cr = tab.RemoveCard();
                InsertCard(cr);
            }
        }
        public int Turns()
        {
            Card cr = null;
            bool found = false;
            int i=0;
            while (found==false && i < hand.Count )
            {
                if (hand[i].GetStatus() == true)
                {
                    cr = hand[i];
                    found = true;
                }
                i++;
            }
            if (found == true)
            {
                for (int j = 0; j <= hand.Count - 1; j++)
                {
                    if (hand[j].GetStatus() == true && cr.GetNum() > hand[j].GetNum())
                    {
                        cr = hand[j];
                    }
                }
                return cr.GetNum();
            }
            else return 20;
        }
        public List<Card> GetHand()
        {
            return hand;
        }
        public int GetCount()
        {
            return hand.Count;
        }
    }
}