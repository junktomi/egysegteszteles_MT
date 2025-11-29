using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egysegteszteles_MT
{
    internal class Tesztek
    {
        JaratKezelo jk;

        [SetUp]

        public void Init()
        {
            jk = new JaratKezelo();
            jk.UjJarat("boeing1", "a", "b", DateTime.Now);
        }

        [Test]

        public void UjLetezikSzam()
        {
            Assert.Throws<ArgumentException>(() =>{
                jk.UjJarat("boeing1", "a", "b", DateTime.Now);
            });
        }

        [Test]

        public void LetezikSzam()
        {
            string tesztJarat = "Teszt";
            jk.UjJarat(tesztJarat, "a", "b", DateTime.Now);

            Assert.That(jk.Jaratok.Exists(x => x.JaratSzam == tesztJarat));
           
        }

        [Test]

        public void MinuszosKeses()
        {
            Assert.Throws<NegativKesesException>(() =>
            {
                jk.Keses("123", -1);
            });
        }

    }
}
