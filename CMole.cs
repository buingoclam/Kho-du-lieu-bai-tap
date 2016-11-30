using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using shoot.Properties;

namespace shoot
{
    class CMole:ClmageBase
    {
        public CMole()
            : base(Resources.ufo)
        {
            _ufoHotSpot.X = Left + 20;
            _ufoHotSpot.Y = Top - 1;
            _ufoHotSpot.Width = 30;
            _ufoHotSpot.Height = 40;
        }
        private Rectangle _ufoHotSpot = new Rectangle();

        public void Update(int X, int Y)
        {
            Left = X;
            Top = Y;
            _ufoHotSpot.X = Left + 20;
            _ufoHotSpot.Y = Top - 1;
        }
        public bool Hit(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1);//Creat a cursor rect - quick way to check for hit.

            if (_ufoHotSpot.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}           


    

