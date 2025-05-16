using System;
using System.Collections.Generic;
using System.Threading;

namespace park_form
{
    internal class Parcheggio
    {
        public Form1 Form { get; }
        public Semaphore SemaforoIngressi { get; } // Limita a 3 ingressi contemporanei
        public Semaphore SemaforoPosti { get; }    // Gestisce i 10 posti totali

        // Aggiungiamo un contatore per i posti disponibili
        private int _postiDisponibili;
        public int PostiDisponibili
        {
            get { return _postiDisponibili; }
            set
            {
                _postiDisponibili = value;
                Form.AggiornaListe();
            }
        }

        public List<Auto> AutoFuori { get; } = new List<Auto>();
        public List<Auto> AutoDentro { get; } = new List<Auto>();
        public List<Auto> AutoInTransito { get; } = new List<Auto>();
        public List<Auto> AutoUscite { get; } = new List<Auto>();

        public Parcheggio(Form1 form)
        {
            Form = form;
            SemaforoIngressi = new Semaphore(3, 3); // Max 3 ingressi contemporanei
            SemaforoPosti = new Semaphore(10, 10);  // 10 posti totali
            PostiDisponibili = 10; // Inizializza i posti disponibili
        }
    }
}