using Tyuiu.ShteltzAV.Sprint1.Task2.V11.Lib;

namespace Tyuiu.ShteltzAV.Sprint1.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Штельц А. В. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в С#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Штельц Александра Владимировна | ПИНб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя данные,          *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Задано текущее время в часах и минутах.                                 *");
            Console.WriteLine("* Вычислить, сколько секунд прошло с начала суток.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int h, m;

            Console.WriteLine("Введите количество часов:");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество минут:");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("С начала суток прошло " + ds.ConvertHoursMinutesToSeconds(h,m) + " секунд.");
            Console.ReadKey();
        }
    }
}
