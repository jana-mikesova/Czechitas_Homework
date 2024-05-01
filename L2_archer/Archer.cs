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
            if (amountOfArrows < 0) 
            {
                amountOfArrows = 0;
            }

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

        public void addArrow(int amount)
        {
            AmountOfArrows += amount;
            Console.WriteLine($"Do toulce bylo přidáno {amount} šípů.");
        }

        public void removeArrow(int amount)
        {   
            if (AmountOfArrows <= amount)
            {
                AmountOfArrows = 0;
                Console.WriteLine("Z toulce odebrány všechny šípy");
            } else
            {
                AmountOfArrows -= amount;
                Console.WriteLine($"Z toulce odebráno {amount} šípů. Zůstalo mi v toulci {AmountOfArrows} šípů.");
            }            
        }

        public void getAmountOfArrows() 
        {
            Console.WriteLine($"V toulci mám {AmountOfArrows} šípů.");
        }

    }
}
