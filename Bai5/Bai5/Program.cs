using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<string> names = new List<string> {"An", "Phuong", "Hoang", "Tien", "Thinh", "Nhat" };
            foreach (string n in names) 
                Console.WriteLine(n);

            Console.WriteLine("\nNhap ten sinh vien muon xoa:");
            string name = Console.ReadLine();

                if(names.Remove(name))
                {
                    Console.WriteLine("\nDa xoa");
                }   
                else
                    Console.WriteLine("\nKhong co ten sinh vien nay");

            Console.WriteLine("\nDanh sach con lai: ");
            foreach(string n in names)
                Console.WriteLine(n);
        }
    }
}
