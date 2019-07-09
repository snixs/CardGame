using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

namespace WindowsApplication1
{
    class Player
    {
        public List<Card> hand;
        int posy = 650;
        private int count;

        public Player(CStack cs) 
        {  
            hand = new List<Card>();
            for (int i = 1; i < 7; i++)
            {
                Card cr = cs.TakeCard();
                InsertCard(cr);
            }
        }

        public void PHand(Graphics g)
        {
            for (int i = 0; i <= hand.Count-1; i++)
            {
                hand[i].DrawCard(g);
            }
        }

        public List<Card> GetHand()
        {
            return hand;
        }
        public int GetCountIn()
        {
            return this.count;
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
                if (count <= 6)
                {
                    cr.SetX(hand[count - 1].GetX() + 76);
                }
                else
                {
                    int i = 0;
                    while (i <= count-2)
                    {
                        hand[i + 1].SetX(hand[i].GetX() + 67/count +45);
                        i++;
                    }
                    cr.SetX(hand[i].GetX() + 67/count +45);
                }
                
            }
            hand.Add(cr);
            count++;
        }
        public Card MovePlayer(int xp, int yp, Table ar)
        {
            Card cr = null;
            int i = 0;
            bool found = false;
            while ((!found))
            {
                if (i > count-1)
                {
                    return null;
                }
                if ((xp > hand[i].GetX()) && (xp < (hand[i].GetX() + 71)) && (yp > hand[i].GetY()) && (yp < (hand[i].GetY() + 96)) && ar.ACheck(hand[i]))
                {
                    cr = hand[i];
                    RemoveCard(i);
                    found = true;
                }
                else
                {
                    i = i + 1;
                }
            }
            return cr;
        }
        public void TakeCards(Table tab)
        {
            Card cr = null;
            while (tab.GetCount()!=0)
            {
                cr = tab.RemoveCard();
                InsertCard(cr);
            }
        }
        public void Draw6(CStack dek)
        {
            while (count < 6 && dek.GetCount() != 0)
            {
                InsertCard(dek.TakeCard());
            }
        }
        public void RemoveCard(int indx)
        {
            int j = indx;
            int place1 = hand[indx].GetX();
            int place2 = 0;
            if (j <= count - 1)
            {
                if (count <= 5 )
                {
                    while (j <= count - 1)
                    {
                        hand[j].SetX(hand[j].GetX() - 76);
                        j++;
                    }
                    hand.Remove(hand[indx]);
                    count--;
                }
                else
                {
                    if (indx != count - 1)
                    {
                        while (j <= count - 2)
                        {
                            place2 = hand[j + 1].GetX();
                            hand[j + 1].SetX(place1);
                            place1 = place2;
                            j++;
                        }
                        hand.Remove(hand[indx]);
                        count--;
                        for (int i = 1; i <= count - 1; i++)
                        {
                            hand[i].SetX(hand[i].GetX() + 5 * i);
                        }
                    }
                    else
                    {
                        hand.Remove(hand[indx]);
                        count--;
                        for (int i = 1; i <= count - 1; i++)
                        {
                            hand[i].SetX(hand[i].GetX() + 5 * i);
                        }
                    }
                }
            }
        }
        public int Turns()
        {
            Card cr = null;
            bool found = false;
            int i = 0;
            while (found==false && i < hand.Count)
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
        public Card Defend(int xp, int yp, Table ar)
        {
            Card cr = null;
            int i = 0;
            bool found = false;
            while ((!found))
            {
                if (i > count - 1)
                {
                    return null;
                }
                if ((xp > hand[i].GetX()) && (xp < (hand[i].GetX() + 71)) && (yp > hand[i].GetY()) && (yp < (hand[i].GetY() + 96)) && ar.DCheck(hand[i]))
                {
                    cr = hand[i];
                    RemoveCard(i);
                    found = true;
                }
                else
                {
                    i = i + 1;
                }
            }
            return cr;
        }
    }
}