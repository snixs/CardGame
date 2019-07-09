using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsApplication1
{
    class Card
    {
        private string cardType;
        private int cardNum;
        private string cardStatus;
        private string cardStaPos;
        private bool kozer;

        public Card(string cT, int cN, string sta)
        {
            this.cardType = cT;
            this.cardNum = cN;
            this.cardStatus = sta;
        }
        public Image GetCardPicture()
        {
            switch (this.cardType)
            {
                case "Heart":
                    return Image.FromFile(Application.StartupPath + "//images/Heart" + this.cardNum + ".png");
                    break;
                case "Diamond":
                    return Image.FromFile(Application.StartupPath + "//images/Dimond" + this.cardNum + ".png");
                    break;
                case "Tilt":
                    return Image.FromFile(Application.StartupPath + "//images/Spade" + this.cardNum + ".png");
                    break;
                case "Leaf":
                    return Image.FromFile(Application.StartupPath + "//images/Club" + this.cardNum + ".png");
                    break;
            }
            return null;
        }
        public string CardStatus
        {
            get
            {
                return this.cardStatus;
            }

            set
            {
                this.cardStatus = value;
            }
        }
        public string CardStaPos
        {
            get
            {
                return this.cardStaPos;
            }

            set
            {
                this.cardStaPos = value;
            }
        }
        public bool KozerSta
        {
            get
            {
                return this.kozer;
            }

            set
            {
                this.kozer = value;
            }
        }
    }
}
