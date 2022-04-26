using System;

namespace PTBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            GiaiB2 pt1 = new GiaiB2(3, 4, 1);
            Console.WriteLine("ket qua {0}" ,pt1.GiaiPT());

            GiaiB2 pt2 = new GiaiB2();
            pt2.A = double.Parse(Console.ReadLine());
            pt2.B = double.Parse(Console.ReadLine());
            pt2.C = double.Parse(Console.ReadLine());
            Console.WriteLine("ket qua {0}", pt2.GiaiPT());

            Console.ReadKey();
        }
    }
}
