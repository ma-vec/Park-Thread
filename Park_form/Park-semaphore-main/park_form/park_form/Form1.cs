using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace park_form
{
    public partial class Form1 : Form
    {
        private Parcheggio parcheggio;
        private List<Auto> tutteAuto = new List<Auto>();
        private bool isRunning = false;
        private Thread simulationThread;

        public Form1()
        {
            InitializeComponent();
            parcheggio = new Parcheggio(this);

            // Inizializza 10 auto
            for (int i = 1; i <= 10; i++)
            {
                var auto = new Auto(i, parcheggio);
                tutteAuto.Add(auto);
                parcheggio.AutoFuori.Add(auto);
            }

            AggiornaListe();
        }

        public void AggiornaListe()
        {
            // Controlla se il form è ancora valido e se i controlli sono stati creati
            if (IsDisposed || listFuori == null || listDentro == null || listTransito == null || listUscite == null)
                return;

            if (InvokeRequired)
            {
                Invoke(new Action(AggiornaListe));
                return;
            }

            try
            {
                // Aggiorna lista AutoFuori
                listFuori.BeginUpdate();
                listFuori.DataSource = null;
                listFuori.DataSource = parcheggio?.AutoFuori;
                listFuori.DisplayMember = "Id";
                listFuori.EndUpdate();

                // Aggiorna lista AutoDentro
                listDentro.BeginUpdate();
                listDentro.DataSource = null;
                listDentro.DataSource = parcheggio?.AutoDentro;
                listDentro.DisplayMember = "Id";
                listDentro.EndUpdate();

                // Aggiorna lista AutoInTransito
                listTransito.BeginUpdate();
                listTransito.DataSource = null;
                listTransito.DataSource = parcheggio?.AutoInTransito;
                listTransito.DisplayMember = "Id";
                listTransito.EndUpdate();

                // Aggiorna lista AutoUscite
                listUscite.BeginUpdate();
                listUscite.DataSource = null;
                listUscite.DataSource = parcheggio?.AutoUscite;
                listUscite.DisplayMember = "Id";
                listUscite.EndUpdate();

                // Aggiorna label
                if (parcheggio != null)
                {
                    lblPostiLiberi.Text = $"Posti liberi: {parcheggio.PostiDisponibili}";
                    lblAutoUscite.Text = $"Auto uscite: {parcheggio.AutoUscite.Count}";
                }
            }
            catch (Exception ex)
            {
                // Puoi loggare l'errore se necessario
                Debug.WriteLine($"Errore durante l'aggiornamento delle liste: {ex.Message}");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isRunning) return;

            isRunning = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            simulationThread = new Thread(() =>
            {
                while (isRunning && parcheggio.AutoFuori.Count > 0)
                {
                    // Fai entrare auto solo se ci sono posti disponibili
                    if (parcheggio.SemaforoPosti.WaitOne(0))
                    {
                        var auto = parcheggio.AutoFuori[0];
                        auto.Start();
                        Thread.Sleep(500); // Piccolo delay tra un'auto e l'altra
                    }

                    Thread.Sleep(100);
                }

                // Quando tutte le auto sono uscite, ferma la simulazione
                isRunning = false;
                Invoke(new Action(() => {
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                }));
            });
            simulationThread.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            simulationThread?.Join(1000);
        }
    }
}