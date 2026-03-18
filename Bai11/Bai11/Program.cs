using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Thinh" });
            students.Add(new Student { Id = 2, Name = "Nhat" });
            students.Add(new Student { Id = 3, Name = "Hoang" });
            students.Add(new Student { Id = 4, Name = "Tien" });

            Console.WriteLine("Danh sach sinh vien: ");
            foreach (var s in students)
                Console.WriteLine($"{s.Id} - {s.Name}");
        }
    }
}
