using SquareConnect.SStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnect
{
    public interface Subject
    {
        void register(Observer o);
        void unregister(Observer o);
        void notify(Observer o);
    }
}
