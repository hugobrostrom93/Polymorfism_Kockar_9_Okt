using Polymorfism_Kockar_9_Okt;

namespace Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef(); // Vi skapar ett objekt av vår chef klass
            chef.MakeChicken(); // Output : "Kocken tillagar kyckling"
            chef.Specialare(); // ... gör en BBQ

            ItalianChef italianChef = new ItalianChef();
            italianChef.Specialare(); // Gör en pizza - Samma metod men vi har ändrat den tack vara virtual + override combo! 

            Console.ReadLine();
        }
    }
}