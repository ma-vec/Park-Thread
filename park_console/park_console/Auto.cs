using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park_console
{
    internal class Auto
    {
        private int id;
        private int tempoPermanenza;
        private Parcheggio parcheggio; //associa auto al parcheggio in cui vuole entrare
        private Thread thread;

        public Auto(int id, int tempoPermanenza, Parcheggio parcheggio)
        {
            this.id = id;
            this.tempoPermanenza = tempoPermanenza;
            this.parcheggio = parcheggio;
            this.thread = new Thread(new ThreadStart(Run));
        }

        public void Start()
        {
            thread.Start();
        }

        private void Run()
        {
            parcheggio.IngressoSemaphore.WaitOne();
            lock (Parcheggio.ConsoleLock)
                Console.WriteLine($"Auto {id} in coda all'ingresso.");

            parcheggio.PostiLiberiSemaphore.WaitOne();
            lock (Parcheggio.ConsoleLock)
                Console.WriteLine($"Auto {id} è entrata nel parcheggio.");

            parcheggio.IngressoSemaphore.Release();

            Thread.Sleep(tempoPermanenza); // Simula tempo di sosta

            parcheggio.UscitaSemaphore.WaitOne();
            lock (Parcheggio.ConsoleLock)
                Console.WriteLine($"Auto {id} in coda all'uscita.");

            Thread.Sleep(1000); // Simula tempo di uscita
            lock (Parcheggio.ConsoleLock)
                Console.WriteLine($"Auto {id} è uscita dal parcheggio.");

            parcheggio.PostiLiberiSemaphore.Release();
            parcheggio.UscitaSemaphore.Release();
        }
    }
}

