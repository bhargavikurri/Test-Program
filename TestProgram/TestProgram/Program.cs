using System;

 class Program
    {
        public static void NumberOperations(int i)
        {
            if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("ModernMedical"); }
            else if (i % 3 == 0) { Console.WriteLine("Modern"); }
            else if (i % 5 == 0) { Console.WriteLine("Medical"); }
            else Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            for(int number = 1; number <= 100; number++)
            {
                NumberOperations(number);
            }
            Console.ReadKey();
        }
    }

