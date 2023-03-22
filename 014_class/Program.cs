using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _014_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            /* for(int i  = 0; i < 10; i++)
             {
                 Console.WriteLine(r.Next());
             }*/
            //10명의 성적을 저장하는 배열 score를 만들고
            //랜덤하게 점수를 생성하여 저장하시오.

            int[] score = new int[10];

            for(int i =0; i < 10; i++)
            {
                score[i] = r.Next(101);
            }

            //최소값, 최대값, 평균값 계산 출력
            int max = 0;
            int min = 100;
            int sum = 0;

            foreach(var x in score) 
            {
                if(x > max)
                {
                    max = x;
                }
                if(x < min)
                {
                    min = x;
                }
                sum += x;
            }
            Console.WriteLine("최소값 : {0}, 최대값 : {1}, 평균값 : {2}", min, max, sum / 10.0);
        }
    }
}
