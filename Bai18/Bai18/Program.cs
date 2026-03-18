using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<Student> list = new List<Student>
                {
                    new Student { Name = "An", Score = 7.5 },
                    new Student { Name = "Binh", Score = 9.0 },
                    new Student { Name = "Cuong", Score = 8.2 },
                    new Student { Name = "Nhat", Score = 9.0 }
                };
            double max = list[0].Score;

            foreach (Student student in list) 
                if (student.Score > max)
                    max= student.Score;
            Console.WriteLine("Sinh vien co diem cao nhat: ");
            foreach (Student s in list)
                if(s.Score == max)
                    Console.WriteLine($"{s.Name} - {s.Score}");
        }
    }
}
