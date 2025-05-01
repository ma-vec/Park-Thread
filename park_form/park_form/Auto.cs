using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park_form
{
    internal class Auto
    {
        public int Id { get; }
        public int TempoPermanenza { get; }
        private Parcheggio parcheggio; //associa auto al parcheggio in cui vuole entrare
        private Thread thread;

        public Auto(int id, int tempoPermanenza, Parcheggio parcheggio)
        {
            this.Id = id;
            this.TempoPermanenza = tempoPermanenza;
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
            parcheggio.CodaIngresso.Enqueue(this);

            
            parcheggio.Form.AggiornaListe();

            parcheggio.PostiLiberiSemaphore.WaitOne();
            parcheggio.CodaIngresso.Dequeue();
            parcheggio.AutoParcheggio.Add(this);
            parcheggio.Form.AggiornaListe();

            parcheggio.IngressoSemaphore.Release();

            Thread.Sleep(TempoPermanenza); // Simula tempo nel parcheggio

            parcheggio.UscitaSemaphore.WaitOne();
            parcheggio.AutoParcheggio.Remove(this);
            parcheggio.CodaUscita.Enqueue(this);
            parcheggio.Form.AggiornaListe();

            Thread.Sleep(1000); // Simula tempo di uscita

            parcheggio.CodaUscita.Dequeue();
            parcheggio.PostiLiberiSemaphore.Release();
            parcheggio.UscitaSemaphore.Release();
            parcheggio.Form.AggiornaListe();
        }

    }
}

