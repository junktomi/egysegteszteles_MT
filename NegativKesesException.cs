using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace egysegteszteles_MT
{
    internal class NegativKesesException : ArgumentException
    {
        public NegativKesesException() : base("Nem lehet negatív késés")
        {

        }
    }
}
