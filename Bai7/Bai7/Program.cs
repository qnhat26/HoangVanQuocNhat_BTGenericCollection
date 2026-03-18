using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
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

            list.Sort();
            Console.WriteLine("Danh sach sau khi sap xep:");
            foreach (int x in list)
                Console.WriteLine(x);
        }
    }
}
