using System;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                string binary = Convert.ToString(num, 2);
                Console.WriteLine(binary);
            }
        }
    }
}
