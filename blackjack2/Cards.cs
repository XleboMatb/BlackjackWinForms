using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack2
{
    
    public class Cards
    {
        public static int x = 113;
        public static int y = 173;
        private static Image cardsSprite = new Bitmap(blackjack2.Properties.Resources.cardsSprite);

        public string Name { get; set; }
        public string mast { get; set; }
        public int cardValue { get; set; }
        public Image cardsPic { get; set; }


        public static Image GetCardBitmap(int x, int y)
        {
            Image card = new Bitmap(129, 170);
            Graphics g = Graphics.FromImage(card);
            g.DrawImage(cardsSprite, 0, 0, new Rectangle(new Point(x, y), new Size(110, 169)), GraphicsUnit.Pixel);
            return card;
        }
        
        public static List<Cards> cardsDeck = new List<Cards>()
        {
            
            //крести
            new Cards() {Name = "Tuz", mast = "clubs", cardValue = 11, cardsPic = GetCardBitmap(0,0)},
            new Cards() {Name = "2", mast = "clubs", cardValue = 2, cardsPic = GetCardBitmap(x,0)},
            new Cards() {Name = "3", mast = "clubs", cardValue = 3, cardsPic = GetCardBitmap(x*2 - 4,0)},
            new Cards() {Name = "4", mast = "clubs", cardValue = 4, cardsPic = GetCardBitmap(x*3 - 4,0)},
            new Cards() {Name = "5", mast = "clubs", cardValue = 5, cardsPic = GetCardBitmap(x*4 - 4,0)},
            new Cards() {Name = "6", mast = "clubs", cardValue = 6, cardsPic = GetCardBitmap(x*5 - 4,0)},
            new Cards() {Name = "7", mast = "clubs", cardValue = 7, cardsPic = GetCardBitmap(x*6 - 4,0)},
            new Cards() {Name = "8", mast = "clubs", cardValue = 8, cardsPic = GetCardBitmap(x * 7 - 4,0)},
            new Cards() {Name = "9", mast = "clubs", cardValue = 9, cardsPic = GetCardBitmap(x * 8 - 4,0)},
            new Cards() {Name = "10", mast = "clubs", cardValue = 10, cardsPic = GetCardBitmap(x * 9 - 10,0)},
            new Cards() {Name = "Jack", mast = "clubs", cardValue = 10, cardsPic = GetCardBitmap(x * 10 - 10,0)},
            new Cards() {Name = "Queen", mast = "clubs", cardValue = 10, cardsPic = GetCardBitmap(x * 11 - 10,0)},
            new Cards() {Name = "King", mast = "clubs", cardValue = 10, cardsPic = GetCardBitmap(x * 12 - 10,0)},
            //буби
            new Cards() {Name = "Tuz", mast = "diamonds", cardValue = 11, cardsPic = GetCardBitmap(0,y)},
            new Cards() {Name = "2", mast = "diamonds", cardValue = 2, cardsPic = GetCardBitmap(x,y)},
            new Cards() {Name = "3", mast = "diamonds", cardValue = 3, cardsPic = GetCardBitmap(x * 2 - 4,y)},
            new Cards() {Name = "4", mast = "diamonds", cardValue = 4, cardsPic = GetCardBitmap(x * 3 - 4,y)},
            new Cards() {Name = "5", mast = "diamonds", cardValue = 5, cardsPic = GetCardBitmap(x * 4 - 4,y)},
            new Cards() {Name = "6", mast = "diamonds", cardValue = 6, cardsPic = GetCardBitmap(x * 5 - 4,y)},
            new Cards() {Name = "7", mast = "diamonds", cardValue = 7, cardsPic = GetCardBitmap(x * 6 - 4,y)},
            new Cards() {Name = "8", mast = "diamonds", cardValue = 8, cardsPic = GetCardBitmap(x * 7 - 4,y)},
            new Cards() {Name = "9", mast = "diamonds", cardValue = 9, cardsPic = GetCardBitmap(x*8 - 4,y)},
            new Cards() {Name = "10", mast = "diamonds", cardValue = 10, cardsPic = GetCardBitmap(x*9 - 10,y)},
            new Cards() {Name = "Queen", mast = "diamonds", cardValue = 10, cardsPic = GetCardBitmap(x*10 -10,y)},
            new Cards() {Name = "Jack", mast = "diamonds", cardValue = 10, cardsPic = GetCardBitmap(x*11 -10,y)},
            new Cards() {Name = "King", mast = "diamonds", cardValue = 10, cardsPic = GetCardBitmap(x * 12 - 10,y)},
            //черви
            new Cards() {Name = "Tuz", mast = "hearts", cardValue = 11, cardsPic = GetCardBitmap(0,y * 2)},
            new Cards() {Name = "2", mast = "hearts", cardValue = 2, cardsPic = GetCardBitmap(x, y * 2)},
            new Cards() {Name = "3", mast = "hearts", cardValue = 3, cardsPic = GetCardBitmap(x*2 - 4,y * 2)},
            new Cards() {Name = "4", mast = "hearts", cardValue = 4, cardsPic = GetCardBitmap(x*3 - 4,y * 2)},
            new Cards() {Name = "5", mast = "hearts", cardValue = 5, cardsPic = GetCardBitmap(x*4 - 4,y * 2)},
            new Cards() {Name = "6", mast = "hearts", cardValue = 6, cardsPic = GetCardBitmap(x*5 - 4,y * 2)},
            new Cards() {Name = "7", mast = "hearts", cardValue = 7, cardsPic = GetCardBitmap(x*6 - 4,y * 2)},
            new Cards() {Name = "8", mast = "hearts", cardValue = 8, cardsPic = GetCardBitmap(x * 7 - 4,y * 2)},
            new Cards() {Name = "9", mast = "hearts", cardValue = 9, cardsPic = GetCardBitmap(x * 8 - 4,y * 2)},
            new Cards() {Name = "10", mast = "hearts", cardValue = 10, cardsPic = GetCardBitmap(x * 9 - 10,y * 2)},
            new Cards() {Name = "Jack", mast = "hearts", cardValue = 10, cardsPic = GetCardBitmap(x * 10 - 10,y * 2)},
            new Cards() {Name = "Queen", mast = "hearts", cardValue = 10, cardsPic = GetCardBitmap(x * 11 - 10,y * 2)},
            new Cards() {Name = "King", mast = "hearts", cardValue = 10, cardsPic = GetCardBitmap(x * 12 - 10,y * 2)},
            //пики 
            new Cards() {Name = "Tuz", mast = "spades", cardValue = 11, cardsPic = GetCardBitmap(0,y * 3)},
            new Cards() {Name = "2", mast = "spades", cardValue = 2, cardsPic = GetCardBitmap(x,y * 3)},
            new Cards() {Name = "3", mast = "spades", cardValue = 3, cardsPic = GetCardBitmap(x*2 - 4,y * 3)},
            new Cards() {Name = "4", mast = "spades", cardValue = 4, cardsPic = GetCardBitmap(x*3 - 4,y * 3)},
            new Cards() {Name = "5", mast = "spades", cardValue = 5, cardsPic = GetCardBitmap(x*4 - 4,y * 3)},
            new Cards() {Name = "6", mast = "spades", cardValue = 6, cardsPic = GetCardBitmap(x*5 - 4,y * 3)},
            new Cards() {Name = "7", mast = "spades", cardValue = 7, cardsPic = GetCardBitmap(x*6 - 4,y * 3)},
            new Cards() {Name = "8", mast = "spades", cardValue = 8, cardsPic = GetCardBitmap(x * 7 - 4,y * 3)},
            new Cards() {Name = "9", mast = "spades", cardValue = 9, cardsPic = GetCardBitmap(x * 8 - 4,y * 3)},
            new Cards() {Name = "10", mast = "spades", cardValue = 10, cardsPic = GetCardBitmap(x * 9 - 10,y * 3)},
            new Cards() {Name = "Jack", mast = "spades", cardValue = 10, cardsPic = GetCardBitmap(x * 10 - 10,y * 3)},
            new Cards() {Name = "Queen", mast = "spades", cardValue = 10, cardsPic = GetCardBitmap(x * 11 - 10,y * 3)},
            new Cards() {Name = "King", mast = "spades", cardValue = 10, cardsPic = GetCardBitmap(x * 12 - 10,y * 3)},
            new Cards() {Name = "HiddenCard", mast = "-", cardValue = 0, cardsPic = GetCardBitmap(0,y * 4)}
        };

    }
}
