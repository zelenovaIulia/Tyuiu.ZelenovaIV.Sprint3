namespace Tyuiu.ZelenovaIV.Sprint3.Task7.V27.Lib;
    class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Зеленова Юлия Владимировна | АСОиУб-25-1";
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* Спринт #3                                                                  *");
        Console.WriteLine("* Sprint3                                                               *");
        Console.WriteLine("* Задание #7                                                                 *");
        Console.WriteLine("* Вариант #27                                                                *");
        Console.WriteLine("* Выполнила: Зеленова Юлия Владимировна | АСОиУб-25-1                        *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                   *");
        Console.WriteLine("* Написать программу,которая выводит таблицу значения функций                *");
        Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне  [-5;5]              *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
        Console.WriteLine("******************************************************************************");

        int startValue = -5;
        int stoptValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stoptValue);

        int len = ds.GetMassFunction(startValue, stoptValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stoptValue);


        Console.WriteLine("******************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
        Console.WriteLine("******************************************************************************");

        Console.WriteLine("+---------------------------------------+-------------------------------------");
        Console.WriteLine("*|                  X                   |                  f(X)              |");
        Console.WriteLine("+---------------------------------------+-------------------------------------");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}                                  | {1, 6:f2}                             |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+---------------------------------------+------------------------------------+");
        Console.ReadKey();
    }
}
}