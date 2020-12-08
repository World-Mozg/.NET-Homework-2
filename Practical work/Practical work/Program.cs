using System;

namespace Practical_work
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            /*
            Console.Write("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            double y = 7 * Math.Pow(x, 2) - 3 * x + 4;
            Console.WriteLine("y=7x^2-3x+4 \ny = " + y);
            */




            //2
            /*
            Console.WriteLine("Введите радиус круга");
            int radiusOfСircle = int.Parse(Console.ReadLine());
            double sOfСircle = 3.14 * Math.Pow(radiusOfСircle, 2);
            double circleLength = 2 * 3.14 * radiusOfСircle;
            Console.WriteLine("Площадь круга: " + sOfСircle);
            Console.WriteLine("Длина круга: " + circleLength);
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
            Console.WriteLine("Сумма цифр: " + (countOfNumbers + countOfTens));
            Console.WriteLine("Произведение цифр: " + countOfNumbers * countOfTens);
            */









            //6
            /*
            Console.WriteLine("Введите четырёхзначное число:");
            int number = int.Parse(Console.ReadLine());
            int summaOfNumbers = 0;
            int productOfNumbers = 1;
            while(number>0)
            {
                Console.WriteLine(number % 10);
               summaOfNumbers += number % 10;
                productOfNumbers= productOfNumbers * (number % 10);
                number = number / 10;
            }
            Console.WriteLine("Сумма чисел: " + summaOfNumbers);
            Console.WriteLine("Произведение чисел: " + productOfNumbers);
            */






            //7
            int number = 456;
            int firstNumber = number / 100;
            Console.WriteLine(firstNumber);
           int secondNumber = number % 100/10;
            Console.WriteLine(secondNumber);
            int thirdNumber = number % 10;
            Console.WriteLine(thirdNumber);
            Console.WriteLine("" + firstNumber + thirdNumber + secondNumber);
        }
    }
}
