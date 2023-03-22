using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine()); //10개의 정수 읽어서 배열에 저장
            }
           /* for (int i =0; i < 10; i++)
            {
                Console.WriteLine(a[i]); //배열에 저장된 10개의 정수 출력
            }*/
           foreach (var value in a)
            {
                Console.WriteLine(value);
            }
        }
    }
}
