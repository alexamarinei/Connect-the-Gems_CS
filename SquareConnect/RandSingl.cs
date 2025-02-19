using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareConnect
{
    public sealed class RandSingl
    {
        private static Random instance = null;
        private static readonly object padlock = new object();

        public static Random rand
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Random();
                    }

                    return instance;
                }
            }
        }
    }
}
