using System;

namespace inluppg4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int xNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp?");
            int oNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O-mönster per rad");
            int oGroups = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int lines = int.Parse(Console.ReadLine());


            for (int lineIndex = 0; lineIndex < lines; lineIndex++)
            {
                bool xSeparator = false;
                for (int i = 0; i < oGroups; i++) 
                {
                    for (int j = 0; j < xNum; j++)
                    {
                        Console.Write('X');
                    }
                    Console.Write('-');
                    for (int k = 0; k < oNum; k++)
                    {
                        Console.Write('O');
                    }
                    Console.Write('-');
                    
                }
                for (int l = 0; l < xNum; l++)
                {
                    Console.Write('X');
                }
                Console.WriteLine();
            }
        }
    }
}