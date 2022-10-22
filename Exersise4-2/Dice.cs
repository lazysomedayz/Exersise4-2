using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise4_2
{
    internal class Dice
    {
        Random random = new Random();
        public int Throw()
        {
            return random.Next(1, 6);
        }
    }
}
