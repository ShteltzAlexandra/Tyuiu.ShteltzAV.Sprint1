using Tyuiu.ShteltzAV.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ShteltzAV.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Штельц А. В. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Штельц Александра Владимировна | ПИНб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя данные,          *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x1, x2, y1, y2;

            Console.WriteLine("Введите значение x1 от 1 до 8:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение x2 от 1 до 8:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y1 от 1 до 8:");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y2 от 1 до 8:");
            y2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Шахматная фигура «Слон» может перейти на другое поле за один ход: " + ds.ElephCanMove(x1, x2, y1, y2));
            Console.ReadKey();
        }
    }
}
