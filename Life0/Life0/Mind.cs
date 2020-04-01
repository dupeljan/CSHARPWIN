using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life0
{
   
    // Imlements choosing of position
    class Mind
    {
        static Random random = new Random();

        public Mind()
        {

        }
        public static int getStep()
        {
            return random.Next() % 4;
        }
    }
}
