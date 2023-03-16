using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("1~100까지의 합 : {0}", sum);

            sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                    sum += i;
            }
            Console.WriteLine("1~100까지 홀수의 합 : {0}", sum);

            double rSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                rSum += 1.0 / i;
            }
            Console.WriteLine("1~100까지 역수의 합 : {0}", rSum);

            Console.Write("구구단의 단을 입력 : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <=9; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", x, i, x * i);
            }

            Console.Write("n을 입력 : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("m을 입력 : ");
            int m = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= m; i++)
            {
                result *= n;
            }
            Console.WriteLine("{0}의 {1}승은 {2}입니다.", n, m, result);

            Console.Write("구하고자 하는 팩토리얼 수를 입력 : ");
            int k = int.Parse(Console.ReadLine());

            int f = 1;

            for(int i = 1; i <= k; i++)
            {
                f *= i;
            }
            Console.WriteLine("{0} 팩토리얼은 {1}", k, f);
        }
    }
}
