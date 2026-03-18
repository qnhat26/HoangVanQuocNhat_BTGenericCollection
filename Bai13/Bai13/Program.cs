using Bai11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
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

            Console.WriteLine("Danh sach co "+students.Count()+" sinh vien");
        }
    }
}
