using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Dice
    {
        private Random random = new Random();
        public int Throw()
        {
            return random.Next(1,7);
        }

    }
}
