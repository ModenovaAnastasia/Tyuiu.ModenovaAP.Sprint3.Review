using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ModenovaAP.Sprint3.Review.V29.Lib;

namespace Tyuiu.ModenovaAP.Sprint3.Review.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Моденова А. П. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Моденова Анастасия Павловна | ИИПб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*            2x - 3                                                       *");
            Console.WriteLine("* F(x) = --------------- + 5x - 6                                         *");
            Console.WriteLine("*         cos(x) - 2x                                                     *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5]           *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль                          *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+--------------+--------------+");
            Console.WriteLine("|      X       |      f(x)    |");
            Console.WriteLine("+--------------+--------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|  {0, 5:d}       |    {1, 6:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+--------------+--------------+");
            Console.ReadKey();
        }
    }
}
