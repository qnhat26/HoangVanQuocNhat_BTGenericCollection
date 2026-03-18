using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<string> list = new List<string> { "Java", "C#", "Python" };
            Console.WriteLine("Danh sach chuoi: ");
            foreach (var item in list)
                Console.WriteLine(item);

            Console.Write("\nNhap chuoi can tim: ");
            string s = Console.ReadLine();

            if (list.Contains(s))
                Console.WriteLine("Co chuoi can tim");
            else
                Console.WriteLine("Khong co chuoi can tim");
        }
    }
}
