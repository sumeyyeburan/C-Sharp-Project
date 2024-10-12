using System;

namespace ZarOyunu 
{
    class Program
    {
        static void Main(string[] args)
        {
            TavlaZari tavlaZari1 = new TavlaZari(8);
            TavlaZari tavlaZari2 = new TavlaZari(8);

            int player1 = tavlaZari1.ZarAt();
            int player2 = tavlaZari1.ZarAt();

            Console.WriteLine("1. oyuncunun attığı zar: " + player1);
            Console.WriteLine("2. oyuncunun attığı zar: " + player2);

            Console.WriteLine();

            if (player1 > player2)
            {
                Console.WriteLine("1. oyuncu kazandı");
            }
            else
            {
                Console.WriteLine("2. oyuncu kazandı");
            }
        }
    }
}