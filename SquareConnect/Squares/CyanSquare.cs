using SquareConnect.Squares;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnect
{
    class CyanSquare:Square,Prototype
    {
        public CyanSquare()
        {
            setColor(Color.Cyan);
        }

        public Square makeCopy()
        {
            return (Square)this.MemberwiseClone();
        }
    }
}
