using System;

namespace uppgift_1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket ord vill du upprepa?");
            string ord = Console.ReadLine();
            Console.WriteLine("Hur många gånger vill du upprepa det?");
            int antal = int.Parse(Console.ReadLine());
            if ( antal < 10 && ord.Length < 10 ) 
            {
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
