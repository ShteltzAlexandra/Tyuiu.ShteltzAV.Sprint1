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
            Console.WriteLine("* Написать программу, которая печатает true или false в зависимости       *");
            Console.WriteLine("* от того, может ли шахматная фигура «Слон» с одного заданного поля       *");
            Console.WriteLine("* шахматной доски перейти за один ход на другое. Пользователь задает      *");
            Console.WriteLine("* координаты двух ячеек шахматной доски                                   *");
            Console.WriteLine("* (x1 и y1, x2 и y2, каждое в диапазоне от 1 до 8).                       *");
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
