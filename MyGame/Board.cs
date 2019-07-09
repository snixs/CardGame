 using System;
//using Unit4.CollectionsLib;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    class Board
    {
        private Player me;
        private Comp comp;
        private CStack deck;
        private Table arena;

        public Board(Graphics g)
        {
            deck = new CStack();
            me = new Player(deck);
            comp = new Comp(deck);
            arena = new Table();
        }
        public Player GetMe()
        {
            return me;
        }
        public CStack GetDeck()
        {
            return deck;
        }
        public Comp GetComp()
        {
            return comp;
        }
        public void ShowBoard(Graphics g)
        {
            me.PHand(g);
            comp.DrawHand(g);
            deck.ShowDeck(g);
            arena.ShowArena(g);
           
        }
        public Table GetArena()
        {
            return arena;
        }
       
        public void ShowTable(Graphics g)
        {
            arena.ShowArena(g);
        }
    }
}