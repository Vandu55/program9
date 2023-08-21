using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program9
{
    internal class Program
    {
        static int[] RemoveDuplicate(int[] array)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();
            foreach(int num in array)
            {
                if(!seen.Contains(num))
                {
                    seen.Add(num);
                    result.Add(num);
                }
            }
            return result.ToArray();
        }
        static void Main(string[] args)
        {
            int[] inputArray = { 2, 3, 4, 4, 5, 6, 8, 9 };
            int[] uniqueArray = RemoveDuplicate(inputArray);

            Console.WriteLine("original Array" + string.Join(",", inputArray));
            Console.WriteLine("Array with Duplicate Removed:" + string.Join(",", uniqueArray));
            Console.ReadLine();
        }
    }
}
