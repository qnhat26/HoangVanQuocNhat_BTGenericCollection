using Bai11;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
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
            Console.Write("Nhap ten sinh vien muon tim: ");
            string name = Console.ReadLine();

            bool found = false;
            foreach (var sv in students)
            {
                if (sv.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Tim thay: {sv.Id} - {sv.Name}");
                    found = true;
                }    
            }
            if(!found)
                Console.WriteLine("Khong tim thay");
        }
    }
}
