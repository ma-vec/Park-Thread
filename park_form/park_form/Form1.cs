namespace park_form
{
    public partial class Form1 : Form
    {
        const int postiTotali = 5;
        const int numIngressi = 2;
        const int numUscite = 3;
        const int numAuto = 10;

        Random rnd = new Random();
        Parcheggio parcheggio;

        public Form1()
        {
            InitializeComponent();

            parcheggio = new Parcheggio(postiTotali, numIngressi, numUscite, this);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= numAuto; i++)
            {
                int tempo = rnd.Next(2000, 5000);
                parcheggio.CodaIngresso.Enqueue(new Auto(i, tempo, parcheggio));
            }

            // Copia in lista per evitare modifica durante enumerazione
            List<Auto> autoList = parcheggio.CodaIngresso.ToList();

            foreach (var auto in autoList)
            {
                int tempoTraArrivi = rnd.Next(500, 2000);
                auto.Start();
                Thread.Sleep(tempoTraArrivi);
            }
        }


        public void AggiornaListe()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(AggiornaListe));
                return;
            }

            listBoxEnter.Items.Clear();
            foreach (var auto in parcheggio.CodaIngresso)
                listBoxEnter.Items.Add($"Auto {auto.Id}");

            listBoxPark.Items.Clear();
            foreach (var auto in parcheggio.AutoParcheggio)
                listBoxPark.Items.Add($"Auto {auto.Id}");

            listBoxExit.Items.Clear();
            foreach (var auto in parcheggio.CodaUscita)
                listBoxExit.Items.Add($"Auto {auto.Id}");
        }
    }

}
