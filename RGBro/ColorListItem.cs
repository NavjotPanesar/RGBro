using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ControlLED
{
    class ColorListItem
    {
        public ColorListItem(Color c)
        { 
            ItemColor = c; 
        }
        public Color ItemColor { get; set; }
        public string HexColor 
        { 
            get 
            {
                return String.Format("{0:X2}{1:X2}{2:X2}", ItemColor.R,
                                                 ItemColor.G,
                                                ItemColor.B);
            }
        }
        public int Red
        {
            get
            {
                return ItemColor.R;
            }
            set
            {
                changeRed(value);
            }
        }
        public int Green
        {
            get
            {
                return ItemColor.G;
            }
            set
            {
                changeGreen(value);
            }
        }
        public int Blue
        {
            get
            {
                return ItemColor.B;
            }
            set
            {
                changeBlue(value);
            }
        }

        private void changeRed(int r)
        {
            ItemColor = Color.FromArgb(255, r, ItemColor.G, ItemColor.B);
        }
        private void changeGreen(int g)
        {
            ItemColor = Color.FromArgb(255, ItemColor.R, g, ItemColor.B);
        }
        private void changeBlue(int b)
        {
            ItemColor = Color.FromArgb(255, ItemColor.R, ItemColor.G, b);
        }
    }
}
