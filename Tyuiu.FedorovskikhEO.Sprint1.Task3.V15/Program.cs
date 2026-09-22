using Tyuiu.FedorovskikhEO.Sprint1.Task3.V15.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Федоровских Е. O. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнила: Федоровских Екатерина Олеговна | ИСТНБ-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите  скорость 1 автомобиля:                                            ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  скорость 2 автомобиля:                                            ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  расстояние           :                                            ");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  время в часах:                                                    ");
            double T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.DistanceOverTime(v1,v2,S,T));
            Console.ReadLine(); 
        }
    }
}
