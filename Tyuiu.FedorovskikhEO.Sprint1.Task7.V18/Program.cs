using Tyuiu.FedorovskikhEO.Sprint1.Task7.V18.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint1.Task7.V18
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Федоровских Екатерина Олеговна | ИСТНБ-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* значениям данных, вводимых пользователем                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(" 1+ sin**2 (x+y)");
            Console.WriteLine(" ---------------");
            Console.WriteLine("                    +x ");
            Console.WriteLine("2 + |(x-2x)/(1+x**2*y**2|");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите  значение х:                                                       ");
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  значение y:                                                       ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
