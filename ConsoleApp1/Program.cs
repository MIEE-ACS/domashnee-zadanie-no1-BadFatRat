using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиусы двух кругов (R1 > R2).");
            Console.Write("Введите радиус первого круга. R1 = ");
            float pi = (float)Math.PI;
            string R1 = Console.ReadLine();
            float r1, r2, S1, S2, S3;
            r1 = CheckNumber(R1);
            Console.Write("Введите радиус второго круга. R2 = ");
            string R2 = Console.ReadLine();
            r2 = CheckNumber(R2);
            if (r1 <= r2)
            {
                Console.WriteLine("R1 должен быть больше чем R2");
                Environment.Exit(0);
            }
            S1 = pi * (float)Math.Pow(r1, 2);
            S2 = pi * (float)Math.Pow(r2, 2);
            S3 = S1 - S2;
            Console.WriteLine("Площадь первого круга: S1 = {0}", Math.Round(S1, 3));
            Console.WriteLine("Площадь второго круга: S2 = {0}", Math.Round(S2, 3));
            Console.WriteLine("Площадь кольца, внешний радиус которого равен R1, а внутренний радиус равен R2: S3 = {0}", Math.Round(S3, 3));
        }
        static float CheckNumber(string user_input) // проверяет, является ли введённое значение числом типа double
        {
            if (float.TryParse(user_input, out float value))
            {
                if (value > 0)
                {
                    return value;
                }
            }
            Console.WriteLine("Введённая вами строка не является нужным числом. Конец программы.");
            Environment.Exit(0);
            return 0;
        }
    }
}
