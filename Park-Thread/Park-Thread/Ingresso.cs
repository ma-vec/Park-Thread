using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_Thread
{
    class Ingresso
    {
        public int TempoIngresso { get; }

        public Queue<Car> codaIngresso = new Queue<Car>();

        public Ingresso(int tempoIngresso)
        {
            tempoIngresso = this.TempoIngresso;
        }
    }
}
