using System;
using System.Collections.Generic;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<int> list = new List<int>();
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.Write("arr["+i+"] = ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            int sum = 0;
            foreach (var x in list)
                sum += x;

            Console.WriteLine("Tong cua cac phan tu trong mang: "+sum);
        }
    }
}
