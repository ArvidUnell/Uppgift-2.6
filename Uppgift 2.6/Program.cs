using System;
namespace Uppgift_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med 3 ord och punkt");
            string mening = Console.ReadLine();

            byte mellanIndex1 = (byte)mening.IndexOf(' ');
            byte mellanIndex2 = (byte)mening.IndexOf(' ',(mellanIndex1+1));
            byte punktIndex = (byte)mening.IndexOf('.');

            string ord1 = mening[..mellanIndex1];
            string ord2 = mening[(mellanIndex1 + 1)..mellanIndex2];
            string ord3 = mening[(mellanIndex2 + 1)..punktIndex];

            Console.WriteLine($"{ord3} {ord2} {ord1}.");

            Console.ReadKey();
        }
    }
}