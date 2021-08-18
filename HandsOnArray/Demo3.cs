using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    class Demo3
    {
        static void Main()
        {
            int[] numbers = { 12, 23, 34, 32, 21, 11, 56, 67, 87, 65, 54 };
            Console.WriteLine("Count: " + numbers.Length);
            Array.Reverse(numbers);
            int[] b = new int[4];
            Array.Copy(numbers, b, 4);
            foreach (int n in b)
                Console.WriteLine(n);
        }
    }
}
