using System;

namespace integer2
{
    class Program
    {
        static void Main(string[] args)
        {
            var K = Convert.ToInt32(Console.ReadLine());
            var result = K / 1000;
            Console.WriteLine(result+" kg");
        }
    }
}