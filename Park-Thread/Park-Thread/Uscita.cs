using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_Thread
{
    class Uscita
    {
        public int TempoUscita { get; }

        public Queue<Car> codaUscita = new Queue<Car>();

        public Uscita(int tempoUscita)
        {
            tempoUscita = this.TempoUscita;
        }
    }
}
