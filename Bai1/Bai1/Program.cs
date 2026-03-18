using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
        }
    }
}
