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
                return System.Drawing.ColorTranslator.ToHtml(ItemColor).Substring(1); 
            }
        }
        public void changeRed(int r)
        {
            ItemColor = Color.FromArgb(255, r, ItemColor.G, ItemColor.B);
        }
        public void changeGreen(int g)
        {
            ItemColor = Color.FromArgb(255, ItemColor.R, g, ItemColor.B);
        }
        public void changeBlue(int b)
        {
            ItemColor = Color.FromArgb(255, ItemColor.R, ItemColor.G, b);
        }
    }
}
