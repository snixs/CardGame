using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Game : Form
    {

        Board game;
        Graphics g;
        Player me;
        Comp comp;
        CStack deck;
        Table arena;
        bool turn; 

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            game = new Board(g);
            arena = game.GetArena();
            deck = game.GetDeck();
            me = game.GetMe();
            comp = game.GetComp();
             if (me.Turns() < comp.Turns())
             {
                 turn = false;
             }
             else
             {
                 turn = true;
             }
             if (turn)
             {
                comp.Atack(arena);
                PaintScreen();
             }
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            PaintScreen();
        }

        private void PaintScreen()
        {
            Bitmap bitmap = new Bitmap(850, 830);
            g = Graphics.FromImage(bitmap);
            g.Clear(this.BackColor);
            g.DrawImage(this.BackgroundImage, new Point(0, 0));
            game.ShowBoard(g);
            g = this.CreateGraphics();
            g.DrawImage(bitmap, new Point(0, 0));
        }
        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Card helpcard = null;
            if (e.Button == MouseButtons.Left)
            {
                if (turn)
                {
                    if (arena.Empty())
                    {
                        comp.Atack(arena);
                        PaintScreen();
                        if (arena.GetANCount()+1 == arena.GetCount())
                        {
                            helpcard = me.Defend(x, y, arena);
                        }
                        if (helpcard != null)
                        {
                            arena.AddAnsCard(helpcard, arena.GetCount() - 1);
                            PaintScreen();
                        }
                    }
                    if (arena.GetANCount() + 1 == arena.GetCount())
                    {
                        helpcard = me.Defend(x, y, arena);
                    }
                    if (helpcard != null)
                    {
                        arena.AddAnsCard(helpcard, arena.GetCount() - 1);
                        PaintScreen();
                    }
                    if (arena.GetANCount() == arena.GetCount())
                    {
                        comp.Atack(arena);
                        PaintScreen();
                    }
                }
                else
                {
                    g = CreateGraphics();
                    helpcard = me.MovePlayer(x, y, arena);
                    if (helpcard != null)
                    {
                        arena.AddCard(helpcard);
                        PaintScreen();
                    }
                    comp.Defend(arena);
                    PaintScreen();
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (!deck.Is_empty())
                {
                    if (turn)
                    {
                        if (arena.GetANCount() == arena.GetCount())
                        {
                            while (arena.GetCount() >= 1)
                            {
                                arena.RemoveCard();
                                turn = false;
                            }
                            me.Draw6(deck);
                            comp.Draw6(deck);
                            PaintScreen();
                        }
                        else
                        {
                            me.TakeCards(arena);
                            PaintScreen();
                            comp.Draw6(deck);
                            PaintScreen();
                            comp.Atack(arena);
                            PaintScreen();
                        }
                    }
                    else
                    {
                        if (arena.GetANCount() == arena.GetCount() && arena.Empty() == false)
                        {
                            while (arena.GetCount() >= 1)
                            {
                                arena.RemoveCard();
                                turn = true;
                            }
                            comp.Draw6(deck);
                            me.Draw6(deck);
                            comp.Atack(arena);
                            PaintScreen();
                        }
                        else
                        {
                            comp.Take(arena);
                            me.Draw6(deck);
                            PaintScreen();
                        }
                    }
                }
                else
                {
                    if (turn)
                    {
                        if (arena.GetANCount() == arena.GetCount())
                        {
                            if (me.GetCountIn() == 0)
                            {
                                MessageBox.Show("You Won the Game Congrats!");
                                this.Close();
                            }
                            else
                            {
                                if (comp.GetCount() == 0)
                                {
                                    MessageBox.Show("You Lost the Game sory!");
                                    this.Close();
                                }
                            }
                            while (arena.GetCount() >= 1)
                            {
                                arena.RemoveCard();
                                turn = false;
                            }
                            PaintScreen();
                            if (me.GetCountIn() == 0)
                            {
                                MessageBox.Show("You Won the Game Congrats!");
                                this.Close();
                            }
                            else
                            {
                                if (comp.GetCount() == 0)
                                {
                                    MessageBox.Show("You Lost the Game sory!");
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            me.TakeCards(arena);
                            PaintScreen();
                            comp.Atack(arena);
                            PaintScreen();
                            if (me.GetCountIn() == 0)
                            {
                                MessageBox.Show("You Won the Game Congrats!");
                                this.Close();
                            }
                            else
                            {
                                if (comp.GetCount() == 0)
                                {
                                    MessageBox.Show("You Lost the Game sory!");
                                    this.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (arena.GetANCount() == arena.GetCount() && arena.Empty() == false)
                        {
                            if (me.GetCountIn() == 0)
                            {
                                MessageBox.Show("You Won the Game Congrats!");
                                this.Close();
                            }
                            else
                            {
                                if (comp.GetCount() == 0)
                                {
                                    MessageBox.Show("You Lost the Game sory!");
                                    this.Close();
                                }
                            }
                            while (arena.GetCount() >= 1)
                            {
                                arena.RemoveCard();
                                turn = true;
                            }
                            comp.Atack(arena);
                            PaintScreen();
                            if (me.GetCountIn() == 0)
                            {
                                MessageBox.Show("You Won the Game Congrats!");
                                this.Close();
                            }
                            else
                            {
                                if (comp.GetCount() == 0)
                                {
                                    MessageBox.Show("You Lost the Game sory!");
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            comp.Take(arena);
                            PaintScreen();
                            if (me.GetCountIn() == 0)
                            {
                                MessageBox.Show("You Won the Game Congrats!");
                                this.Close();
                            }
                            else
                            {
                                if (comp.GetCount() == 0)
                                {
                                    MessageBox.Show("You Lost the Game sory!");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}