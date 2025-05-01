using park_console;

const int postiTotali = 5;
const int numIngressi = 2;
const int numUscite = 3;
const int numAuto = 10;

Parcheggio parcheggio = new Parcheggio(postiTotali,numIngressi,numUscite);

List<Auto> autoQueue = new List<Auto>();
Random rnd = new Random();

for (int i = 1; i <= numAuto; i++)
{
    int tempo = rnd.Next(2000, 5000);
    autoQueue.Add(new Auto(i, tempo, parcheggio));
}

foreach (var auto in autoQueue)
{
    int tempoTraArrivi = rnd.Next(500, 2000);
    auto.Start();
    Thread.Sleep(tempoTraArrivi); // Simula arrivo scaglionato
}

Console.ReadLine(); // Mantieni la console aperta
