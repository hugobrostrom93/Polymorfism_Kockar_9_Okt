using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Kockar_9_Okt
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Kocken tillagar kyckling");
        }

        public void MakeSallad()
        {
            Console.WriteLine("Kocken gör sallad");
        }

        public void MakeBBQ()
        {
            Console.WriteLine("Kocken gör BBQ");
        }

        public virtual void Specialare() // virtual så vi kan köra en override på en av våra sub-klasser
        {
            Console.WriteLine("Den vanliga kocken gör en BBQ");
        }
    }
}
