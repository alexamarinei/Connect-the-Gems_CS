using SquareConnect.Squares;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnect
{
    class LimeSquare:Square, Prototype
    {
        public LimeSquare()
        {
            setColor(Color.Lime);
        }
        public Square makeCopy()
        {
            return (Square)this.MemberwiseClone();
        }
    }
}
