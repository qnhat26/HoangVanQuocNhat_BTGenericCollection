using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<int> list = new List<int>();

            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            int max = list[0];
            foreach (int i in list)
                if(i > max)
                    max=i;
            Console.WriteLine("So lon nhat :"+max);
        }
    }
}
