using System;

namespace perfect_number_task
{
    class Program
    {
        public static int isperfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }

            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int secondnum = int.Parse(Console.ReadLine());
            int result;
            for (int i = firstnum; i < secondnum; i++)
            {
                result = isperfect(i);
                if (i == result)
                {
                    Console.WriteLine("THE NUMBER {0} IS PERFECT", i);
                }
            }




        }
    }
}

