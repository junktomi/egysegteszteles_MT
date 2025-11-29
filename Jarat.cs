using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egysegteszteles_MT
{
    internal class Jarat
    {
        private string jaratSzam;
        private string honnanRepter;
        private string hovaRepter;
        private DateTime indulas;
        private int keses;

        public Jarat(string jaratSzam, string honnanRepter, string hovaRepter, DateTime indulas, int keses)
        {
            this.jaratSzam = jaratSzam;
            this.honnanRepter = honnanRepter;
            this.hovaRepter = hovaRepter;
            this.indulas = indulas;
            this.keses = keses;
        }

        public string JaratSzam { get => jaratSzam; set => jaratSzam = value; }
        public string HonnanRepter { get => honnanRepter; set => honnanRepter = value; }
        public string HovaRepter { get => hovaRepter; set => hovaRepter = value; }
        public DateTime Indulas { get => indulas; set => indulas = value; }
        public int Keses { get => keses; set => keses = value; }
    }
}
