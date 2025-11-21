using Tyuiu.ZelenovaIV.Sprint3.Task0.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Зеленова Ю. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выпонил: Зеленова Юлия Владимировна | АСОиУб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* переводит дюймы в метры и округляет результат до трёх цифр после запятой*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        int x = 5, kEnd = 6, kStart = 1;
        Console.WriteLine("x = " + x);
        Console.WriteLine("Начальное k = " + kStart);
        Console.WriteLine("Конечное k = " + kEnd);
        Console.WriteLine("РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(ds.GetMultiplySeries(x, kStart, kEnd));
        Console.ReadLine();
    }
}