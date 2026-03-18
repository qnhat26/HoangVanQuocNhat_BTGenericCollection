using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            Console.Write("Nhap chuoi :");
            string s = Console.ReadLine();

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s)
                if(dic.ContainsKey(c))
                    dic[c] ++;
                else
                    dic[c] = 1;
            foreach(var item in dic)
                Console.WriteLine($"{item.Key}:{item.Value}");
        }
    }
}
