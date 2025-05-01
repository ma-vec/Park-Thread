using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace park_form
{
    internal class Parcheggio
    {
        public Form1 Form { get; }
        public Semaphore IngressoSemaphore { get; set; }
        public Semaphore UscitaSemaphore { get; set; }
        public Semaphore PostiLiberiSemaphore { get; set; }

        public Queue<Auto> CodaIngresso = new Queue<Auto>();
        public Queue<Auto> CodaUscita = new Queue<Auto>();
        public List<Auto> AutoParcheggio = new List<Auto>();

        public Parcheggio(int postiTotali, int numeroIngressi, int numeroUscite, Form1 form)
        {
            IngressoSemaphore = new Semaphore(numeroIngressi, numeroIngressi);
            UscitaSemaphore = new Semaphore(numeroUscite, numeroUscite);
            PostiLiberiSemaphore = new Semaphore(postiTotali, postiTotali);
            Form = form;
        }
    }
}
