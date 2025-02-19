using SquareConnect.Squares;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnect
{
    class RedSquare:Square, Prototype
    {
        public RedSquare()
        {
            setColor(Color.Red);
        }
        public Square makeCopy()
        {
            return (Square)this.MemberwiseClone();
        }
    }
}
