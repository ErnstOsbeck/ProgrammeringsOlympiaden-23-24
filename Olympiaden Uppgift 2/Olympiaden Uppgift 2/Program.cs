using System;

namespace uppgift_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N?");
            int N = int.Parse(Console.ReadLine());
            int antal = 0;
            for (int i = 1; i < N; i++)
            {
                int a = i;
                int b = i + 1;
                int c = i + 2;
                int d = a * b * c;
                if (d < N)
                {
                    antal++;
                }
            }
            Console.WriteLine("Svar: " + antal);
            Console.Read();
        }
    }
}
