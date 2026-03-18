using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["hello"] = "xin chao";
            dic["dog"] = "con cho";
            dic["book"] = "sach";

            Console.Write("Nhap tu tieng anh: ");
            string key = Console.ReadLine();

            if (dic.ContainsKey(key))
                Console.WriteLine("Nghia: " + dic[key]);
            else
                Console.WriteLine("Khong tim thay");
        }
    }
}
