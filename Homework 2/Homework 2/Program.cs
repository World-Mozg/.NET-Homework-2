using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            /*
            Console.WriteLine("Введите любые три числа:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(number1+"  "+number2+"  "+number3);
            */



            //2
            /*
            int number1 = 5;
            int number2 = 10;
            int number3 = 21;

            Console.WriteLine(number1 +"\n"+ number2 + "\n" + number3);

            // Console.WriteLine(number1);
            //Console.WriteLine(number2);
            // Console.WriteLine(number3);
            */





            //3
            /*
            int centimeter = int.Parse(Console.ReadLine());
            int fullMeters = centimeter / 100;
            Console.WriteLine("В " + centimeter + " сантиметрах " + fullMeters + " полных метров");
            */





            //4
            /*
            int fullWeeks = 234 / 7;
            Console.WriteLine("Прошло " + fullWeeks + " полных недель");
            */





            //5
            /*
            Console.WriteLine("Введите двузначное число:");
            int number = int.Parse(Console.ReadLine());
            int countOfTens = number / 10;
            int countOfNumbers = number % 10;
            Console.WriteLine("Число десятков: " + countOfTens);
            Console.WriteLine("Число единиц: " + countOfNumbers);
            Console.WriteLine("Произведение цифр: " + countOfNumbers* countOfTens);
            */






            //6
            /*
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);
            */





            //7
            /*
            Console.WriteLine("Введите радиус круга");
            int radiusOfСircle = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата");
            int sideOfSquare = int.Parse(Console.ReadLine());
            double sOfСircle = 3.14 * Math.Pow(radiusOfСircle, 2);
            double sOfSquare= Math.Pow(sideOfSquare, 2);
            Console.WriteLine("Площадь круга: " + sOfСircle);
            Console.WriteLine("Площадь квадрата: " + sOfSquare);
            if (sOfСircle > sOfSquare)
                Console.WriteLine("Площадь круга больше");
            else if (sOfСircle < sOfSquare)
                Console.WriteLine("Площадь квадрата больше");
            else
                Console.WriteLine("Площади равны");
            */






            //8
            /*
            Console.WriteLine("Введите массу и объём первого объекта");
            double m1= double.Parse(Console.ReadLine());
            double v1 = double.Parse(Console.ReadLine());
            double P1 = m1 / v1;
            Console.WriteLine("Введите массу и объём второго объекта");
            double m2 = double.Parse(Console.ReadLine());
            double v2 = double.Parse(Console.ReadLine());
            double P2 = m2 / v2;
            Console.WriteLine("Плотность первого объекта: " + P1);
            Console.WriteLine("Плотность второго объекта: " + P2);
            if (P1 > P2)
                Console.WriteLine("Плотность первого объекта больше плотности второго оюъекта");
            else if (P1 < P2)
                Console.WriteLine("Плотность первого объекта меньше плотности второго оюъекта");
            else
                Console.WriteLine("Плотности равны");
            */







            //9
            /*
            Console.WriteLine("Введите сопротивление и напряжение первой цепи");
            double R1 = double.Parse(Console.ReadLine());
            double U1 = double.Parse(Console.ReadLine());
            double I1 = U1 / R1;
            Console.WriteLine("Введите сопротивление и напряжение второй цепи");
            double R2 = double.Parse(Console.ReadLine());
            double U2 = double.Parse(Console.ReadLine());
            double I2 = U2 / R2;
            Console.WriteLine("Сила тока в первой электрической цепи  : " + I1);
            Console.WriteLine("Сила тока во второй электрической цепи: " + I2);
            if (I1 > I2)
                Console.WriteLine("Сила тока во второй цепи меньше, чем в первой");
            else if (I1 < I2)
                Console.WriteLine("Сила тока в первой цепи меньше, чем во второй");
            else
                Console.WriteLine("Силы тока равны");
            */







            //10
            //a
            /*
            for (int i=20;i<=35;i++)
            {
                Console.WriteLine(i);
            }*/
            //b
            /*
            int b= int.Parse(Console.ReadLine());
            for(int i=10;i<=b;i++)
            {
                Console.WriteLine(Math.Pow(i,2));
            }
            */
            //c
            /*
            int a = int.Parse(Console.ReadLine());
            while(a<50)
            {
                Console.WriteLine(Math.Pow(a, 3));
                a++;
            }
            */
            //d
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a <= b)
            {
                Console.WriteLine(a);
                a++;
            }



        }
    }
}
