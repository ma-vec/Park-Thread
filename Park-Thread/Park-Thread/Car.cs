using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_Thread
{
    class Car
    {
        public string Marca { get; }

        public string Modello { get; }

        public string Targa { get; }

        public int TempoSosta {get;}

        public Car(string Marca, string Modello, string Targa, int TempoSosta)
        {
            Marca = this.Marca;
            Modello = this.Modello;
            Targa = this.Targa;
            TempoSosta = this.TempoSosta;
        }
    }
}
