using System;

namespace uppgift_1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordet?");
            string ord = Console.ReadLine();
            Console.WriteLine("antal upprepningar?");
            int antal = int.Parse(Console.ReadLine());
            if ( antal < 10 && ord.Length < 10 ) 
            {
                Console.Write(Svar: );
                for (int i = 0; i < antal; i++)
                {
                    Console.Write(ord);
                }
            }
            else
            {
                Console.WriteLine("Ordet kan inte upprepas fler än 9 gånger eller vara längre än 9 bokstäver");
            }
            Console.Read();
        }
    }
}
