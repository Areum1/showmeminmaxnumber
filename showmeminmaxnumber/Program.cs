using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0, max, min;

            Console.Write("숫자를 입력해주세요: ");
            input = int.Parse(Console.ReadLine());
            max = input;
            min = input;
            for (int i=0; i<4; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                input = int.Parse(Console.ReadLine());

                if (max < input) 
                    max = input;

                if (min > input)
                    min = input;
            }
            Console.WriteLine("========================");
            Console.WriteLine("가장 큰 수: "+max);
            Console.WriteLine("가장 작은 수: " + min);
        }
    }
}
