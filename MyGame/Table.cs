using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsApplication1
{
    class Table
    {
        private List<Card> arena;
        private int ansindx;
        public Table()
        {
            arena = new List<Card>();
            ansindx = 0;
        }
        public void ShowArena(Graphics g)
        {
            for (int i = 0; i < arena.Count; i++)
            {
                if (arena[i] != null)
                {
                    arena[i].DrawCard(g);
                }
                else
                {
                    break;
                }
            }
        }
        public void AddCard(Card cr)
        {
            if (GetCount() == 0)
            {
                cr.SetX(100);
                cr.SetY(360);
                arena.Add(cr);
            }
            else
            {
                if ((ansindx*2) == GetCount())
                {
                    cr.SetX((arena[GetCount() - 2].GetX()) + 75);
                    cr.SetY(arena[GetCount() - 2].GetY());
                    arena.Add(cr);
                }
                else
                {
                    cr.SetX((arena[GetCount() - 1].GetX()) + 75);
                    cr.SetY(arena[GetCount() - 1].GetY());
                    arena.Add(cr);
                }
            }
        }
        public void AddAnsCard(Card cr, int indx)
        {
            if (ansindx == 0)
            {
                arena.Insert(indx +1, cr);
                cr.SetX(arena[indx].GetX() + 20);
                cr.SetY(arena[indx].GetY() - 20);
            }
            else
            {
                if ((ansindx * 2) + 1 == GetCount())
                {

                    arena.Add(cr);
                    cr.SetX(arena[indx].GetX() + 20);
                    cr.SetY(arena[indx].GetY() - 20);
                }
                else
                {
                    arena.Insert(indx + 1, cr);
                    cr.SetX(arena[indx].GetX() + 20);
                    cr.SetY(arena[indx].GetY() - 20);
                }
            }
            ansindx++;
        }      
        public Card RemoveCard()
        {
            Card cr = arena[0];
            arena.Remove(arena[0]);
            ansindx=0;
            return cr;
        }
        public Card GetCard(int indx)
        {
            return arena[indx];
        }
        public int GetCount()
        {
            return arena.Count;
        }
        public int GetANCount()
        {
            return (ansindx*2); 
        }
        public bool Empty()
        {
            if (arena.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DCheck(Card cr)
        {
            if ((arena[GetCount() - 1].GetNum() < cr.GetNum() && arena[GetCount() - 1].GetCardType() == cr.GetCardType()))
            {
                return true;
            }
            else
            {
                if (cr.GetStatus() == true)
                {
                    return true;
                }
                else return false;
            }
        }
        public bool ACheck(Card cr)
        {
            if (GetCount() == 0)
            {
                return true;
            }
            else
                for (int i = 0; i <= GetCount() - 1; i++)
                {
                    if (arena[i].GetNum() == cr.GetNum())
                    {
                        return true;
                    }
                }
            return false;
        }
    }
}