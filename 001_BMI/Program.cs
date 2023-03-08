using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("키(cm) = ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("체중(kg) = ");
            double weight = double.Parse(Console.ReadLine());

            double BMI = weight / (height / 100 * height / 100);
            //Console.WriteLine("BMI = " + BMI);
            //Console.WriteLine("BMI = {0,20:F2}", bmi);
            //Console.WriteLine("CMI = {0,20:F2}", 5897563.564787);

            Console.WriteLine("BMI = {0:F2}", BMI);
            //Console.WriteLine("BMI = {0:#.##}", bmi);
        }
    }
}
