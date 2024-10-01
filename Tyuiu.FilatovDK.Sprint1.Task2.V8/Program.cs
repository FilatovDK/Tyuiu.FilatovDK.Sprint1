using Tyuiu.FilatovDK.Sprint1.Task2.V8.Lib;

namespace Tyuiu.FilatovDK.Sprint1.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Филатов Д. К. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание#2                                                               *");
            Console.WriteLine("* Вариант#8                                                               *");
            Console.WriteLine("* Выполнил: Филатов Денис Константинович | СМАРТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* Длина первой стороны прямоугольника, Длина второй стороны прямоугольника*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* (a + b) * 2                                                             *");
            Console.WriteLine("***************************************************************************");

            int a, b;

            Console.WriteLine("Введите длину первой стороны прямоугольника A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длинну второй стороны прямоугольника B:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculatePerimetr(a, b));

            Console.ReadLine();
        }
    }
}

