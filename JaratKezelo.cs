using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egysegteszteles_MT
{
    public class JaratKezelo
    {
        private List<Jarat> jaratok = new List<Jarat>();

        internal List<Jarat> Jaratok { get => jaratok; set => jaratok = value; }

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            if(jaratok.Exists(x => x.JaratSzam == jaratSzam))
            {
                throw new ArgumentException("Nem lehet ugyanaz a járatszám!");
            }
            else
            {
                jaratok.Add(new Jarat(jaratSzam, repterHonnan, repterHova, indulas, 0));

            }
        }

        public void Keses(string jaratSzam, int keses)
        {
            if (jaratok.Exists(x => x.JaratSzam == jaratSzam))
            {
                jaratok.Find(x => x.JaratSzam == jaratSzam).Keses += keses;
            }
            else
            {
                
                throw new ArgumentException("Nincs ilyen számú járat!");

            }

            if (jaratok.Find(x=> x.JaratSzam == jaratSzam).Keses < 0)
            {
                throw new NegativKesesException();
            }

            
        }

        public DateTime MikorIndul(string jaratSzam)
        {
            if (jaratok.Exists(x => x.JaratSzam == jaratSzam))
            {
                
                Jarat adottJarat = jaratok.Find(x => x.JaratSzam == jaratSzam);
                return adottJarat.Indulas.AddSeconds(adottJarat.Keses);
                
            }
            else
            {

                throw new ArgumentException("Nincs ilyen számú járat!");

            }
        }

        public List<string> jaratokRepuloterrol(string repter)
        {
            List<string> repterJaratok = new List<string>();

            if (jaratok.Exists(x => x.HonnanRepter == repter))
            {
                foreach(Jarat jarat in jaratok.FindAll(x => x.HonnanRepter == repter))
                {
                    repterJaratok.Add(jarat.JaratSzam);
                }
            }
            return repterJaratok;
        }
        
    }

}
