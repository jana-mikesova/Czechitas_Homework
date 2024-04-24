using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_archer
{
    internal class Archer
    {
        public int AmountOfArrows;

        public Archer() 
        {
            AmountOfArrows = 10;
        }

        public Archer(int amountOfArrows)
        {
            AmountOfArrows = amountOfArrows;
        }

        public void shotArrow()
        {            
            if (AmountOfArrows > 0)
            {
                Console.WriteLine("Vždy se trefím přímo doprostřed!");               
            } else
            {
                Console.WriteLine("Nemám šípy.");
            }
            AmountOfArrows--;
        }
    }
}
