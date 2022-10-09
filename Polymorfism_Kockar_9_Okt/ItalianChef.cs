using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Kockar_9_Okt
{
    internal class ItalianChef : Chef // Kan göra allt som vår vanliga Chef kan göra
    {
        public void MakePasta() // Nu kan den italienska kocken göra pasta men inte den vanliga
        {
            Console.WriteLine("Den italienska kocken gör pasta");
        }

        public override void Specialare()
        {
            Console.WriteLine("Den italienska kocken gör en smaskig pizza");
        }
    }
}
