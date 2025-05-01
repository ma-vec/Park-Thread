using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park_console
{
    internal class Parcheggio
    {
        public Semaphore IngressoSemaphore { get; set; }
        public Semaphore UscitaSemaphore { get; set; }
        public Semaphore PostiLiberiSemaphore { get; set; }

        //Evita la scrittura in contemporanea (https://stackoverflow.com/questions/1522936/how-do-i-lock-the-console-across-threads-in-c-net)
        public static object ConsoleLock = new object();

        public Parcheggio(int postiTotali, int numeroIngressi, int numeroUscite)
        {
            IngressoSemaphore = new Semaphore(numeroIngressi, numeroIngressi);
            UscitaSemaphore = new Semaphore(numeroUscite, numeroUscite);
            PostiLiberiSemaphore = new Semaphore(postiTotali, postiTotali);
        }
    }
}
