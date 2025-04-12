using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_Thread
{
    class Park
    {
        public int Ingressi { get; }
        public int Uscite { get; }
        public int Posti { get; }

        public Park(int ingressi, int uscite, int posti)
        {
            Ingressi = ingressi;
            Uscite = uscite;
            Posti = posti;
            Semaphore semIngressi = new Semaphore(0, ingressi);
            Semaphore semUscite = new Semaphore(0, uscite);
        }
    }
}
