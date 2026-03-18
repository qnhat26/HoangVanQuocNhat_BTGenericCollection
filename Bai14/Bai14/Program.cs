using Bai11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<Student> students = new List<Student>
            {
            new Student { Id = 1, Name = "Thinh" },
            new Student { Id = 2, Name = "Nhat" },
            new Student { Id = 3, Name = "Hoang" },
            new Student { Id = 4, Name = "Tien" }
            };

            Console.Write("Nhap ID sinh vien can xoa: ");
            int id = int.Parse(Console.ReadLine());

            bool removed = students.RemoveAll(x => x.Id == id) > 0;

            if (removed)
                Console.WriteLine("Da xoa");
            else Console.WriteLine("Khong co sinh vien can xoa");
        }
    }
}
