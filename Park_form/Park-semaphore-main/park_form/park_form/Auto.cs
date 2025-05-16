using System;
using System.Threading;

namespace park_form
{
    internal class Auto
    {
        public int Id { get; }
        public int TempoPermanenza { get; }
        private Parcheggio parcheggio;
        private Thread thread;
        private Random random = new Random();

        public Auto(int id, Parcheggio parcheggio)
        {
            Id = id;
            this.parcheggio = parcheggio;
            TempoPermanenza = random.Next(3000, 10000); // Tempo casuale tra 3 e 10 secondi
            thread = new Thread(Run);
        }

        public void Start()
        {
            thread.Start();
        }

        private void Run()
        {
            try
            {
                // Entrata
                parcheggio.SemaforoIngressi.WaitOne();
                lock (parcheggio.AutoFuori)
                {
                    parcheggio.AutoFuori.Remove(this);
                }
                lock (parcheggio.AutoInTransito)
                {
                    parcheggio.AutoInTransito.Add(this);
                }
                parcheggio.Form.AggiornaListe();

                parcheggio.SemaforoPosti.WaitOne();
                parcheggio.PostiDisponibili--; // Decrementa i posti disponibili
                lock (parcheggio.AutoInTransito)
                {
                    parcheggio.AutoInTransito.Remove(this);
                }
                lock (parcheggio.AutoDentro)
                {
                    parcheggio.AutoDentro.Add(this);
                }
                parcheggio.SemaforoIngressi.Release();
                parcheggio.Form.AggiornaListe();

                // Tempo nel parcheggio
                Thread.Sleep(TempoPermanenza);

                // Uscita
                lock (parcheggio.AutoDentro)
                {
                    parcheggio.AutoDentro.Remove(this);
                }
                lock (parcheggio.AutoInTransito)
                {
                    parcheggio.AutoInTransito.Add(this);
                }
                parcheggio.Form.AggiornaListe();

                Thread.Sleep(1000); // Simula tempo di uscita

                lock (parcheggio.AutoInTransito)
                {
                    parcheggio.AutoInTransito.Remove(this);
                }
                lock (parcheggio.AutoUscite)
                {
                    parcheggio.AutoUscite.Add(this);
                }
                parcheggio.SemaforoPosti.Release();
                parcheggio.PostiDisponibili++; // Incrementa i posti disponibili
                parcheggio.Form.AggiornaListe();
            }
            catch (ThreadAbortException)
            {
                // Gestione eventuale interruzione thread
            }
        }
    }
}