using System;

namespace Uppgift_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X ska finnas per grupp?");
            int xVarde = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O ska finnas per grupp?");
            int oVarde = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O-grupper ska det finnas?");
            int oGrupper = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader ska det vara?");
            int rader = int.Parse(Console.ReadLine());

            for (int i = 0; i < rader; i++)
            {
                for (int j = 0; j < oGrupper; j++) 
                {
                    for (int k = 0; k < xVarde; k++)
                        Console.Write("X");
                    for (int l = 0; l < oGrupper; l++)
                        Console.Write("O");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}