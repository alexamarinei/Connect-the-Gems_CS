using SquareConnect.SStack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareConnect
{
    class Square:Panel , Observer
    {
        public void setColor(Color c)
        {
            this.BackColor = c;
        }

        public void update()
        {
            int type = RandSingl.rand.Next(1, 4);
            switch (type)
            {
                case 1: this.BackColor = Color.Red; break;
                case 2: this.BackColor = Color.Cyan; break;
                case 3: this.BackColor = Color.Lime; break;
            }
        }
    }
}
