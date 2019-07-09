using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WindowsApplication1
{
    class Card
    {
        private bool status;
        private int cardType;
        private int cardNum;
        private Image pic;
        private Image picOp;
        private int Xplace;
        private int Yplace;

        public Card(int cT, int cN, Image pic)
        {
            this.cardType = cT;
            this.cardNum = cN;
            this.status = false;
            this.picOp = Image.FromFile("fv.png");
            this.pic = pic;
            this.Xplace = 0;
            this.Yplace = 0;
        }

        public void DrawOpCard(Graphics g)
        {
            Image pic1;
            pic1 = this.picOp;
            Rectangle r = new Rectangle(Xplace, Yplace, 71, 96);
            g.DrawImage(pic1, r);

        }
        public void DrawCard(Graphics g)
        {

            switch (cardType)
            {
                case 1:
                    pic = Image.FromFile("Heart" + this.cardNum + ".png");
                    break;

                case 2:
                    pic = Image.FromFile("Spade" + this.cardNum + ".png");

                    break;

                case 3:
                    pic = Image.FromFile("Dimond" + this.cardNum + ".png");
                    break;

                case 4:
                    pic = Image.FromFile("Club" + this.cardNum + ".png");
                    break;
            }

            Image pic1;
            Rectangle r = new Rectangle(Xplace, Yplace, 71, 96);
            pic1 = this.pic;
            g.DrawImage(pic1, r);
        }

        public void DrawKCard(Graphics g)
        {
            switch (cardType)
            {
                case 1:
                    pic = Image.FromFile("Heart" + this.cardNum + "f.png");
                    break;

                case 2:
                    pic = Image.FromFile("Spade" + this.cardNum + "f.png");

                    break;

                case 3:
                    pic = Image.FromFile("Dimond" + this.cardNum + "f.png");
                    break;

                case 4:
                    pic = Image.FromFile("Club" + this.cardNum + "f.png");
                    break;
            }


            Image pic1;
            Rectangle r = new Rectangle(Xplace,Yplace, 96, 71);
            pic1 = this.pic;
            g.DrawImage(pic1, r);            
        }

        public int GetCardType()
        {
            return this.cardType;
        }
        public void SetType(int value)
        {
            this.cardType = value;
        }
        
        public int GetNum()
        {
            return this.cardNum;
        }
        public void  SetNum(int value)
        {
            this.cardNum = value;
        }
        
        public int GetX()
        {
            return this.Xplace;
        }
        public void SetX(int value)
        {
           this.Xplace = value;
        }
        
        public int GetY()
        {                       
            return this.Yplace;
        }
        public void SetY(int value)
        {
            this.Yplace = value;
        }

        public bool GetStatus()                 
        {
           return this.status;
        }
        public void SetStatus(bool s)
        {
           this.status = s;
        }

        public Image GetPic()
        {     
            return this.pic;
        }
        public void SetImage(Image p)
        {
            this.pic = p;
        }
   }
}
