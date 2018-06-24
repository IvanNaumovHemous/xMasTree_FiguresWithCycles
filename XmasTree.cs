husing System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            GetChristmasTree(size);
        }

        static void GetChristmasTree(int number)
        {
            int stars = 0;
            int spaces = number;

            for (int i = 0; i <= number; i++)
            {
                stars = i;
                Console.WriteLine("{1}{0} | {0}{1}", new string('*', stars), new string(' ', spaces));
                spaces--;
            }
        }
    }
}
