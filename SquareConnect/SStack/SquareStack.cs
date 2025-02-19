using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnect.SStack
{
    class SquareStack : Subject
    {
        private List<Observer> observers;

        public SquareStack()
        {
            observers = new List<Observer>();
        }
        public void notify(Observer o)
        {
            observers[observers.IndexOf(o)].update();
        }

        public void register(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void unregister(Observer o)
        {
            observers.Remove(o);
        }
    }
}
