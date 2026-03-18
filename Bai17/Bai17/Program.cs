using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoang Van Quoc Nhat 2415053122332\n");
            List<int> num = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();

            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                num.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int i in num)
                if (dic.ContainsKey(i)) 
                    dic[i]++;
                else 
                    dic[i] = 1;

            int maxValue = 0;
            int result = num[0];
            foreach(var item in dic) 
                if(item.Value > maxValue)
                {
                    maxValue = item.Value;
                    result = item.Key;
                }
            Console.WriteLine("Phan tu nhieu nhat: "+result);      
        }
    }
}
