using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычетание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Квадратный корень");

            Console.Write("Введите номер операции (1-5): ");
            int choise = Convert.ToInt32(Console.ReadLine());

          


            double result = 0.0;

            switch(choise)
            {
                case 1:
                    Console.Write("Введите второе число: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());
                    result = number1 + number2;
                    break;
                case 2:
                    Console.Write("Введите второе число: ");
                    double number3 = Convert.ToDouble(Console.ReadLine());
                    result = number1 - number3;
                    break;
                case 3:
                    Console.Write("Введите второе число: ");
                    double number4 = Convert.ToDouble(Console.ReadLine());
                    result = number1 * number4;
                    break;
                case 4:
                    Console.Write("Введите второе число: ");
                    double number5 = Convert.ToDouble(Console.ReadLine());
                    if (number5 == 0)
                    {
                        Console.WriteLine("Ошибка, нельзя делить на ноль");
                        return;
                    }
                    result = number1 / number5;
                    break;
                case 5:
                    if (number1 < 0)
                    {
                        Console.WriteLine("Ошибка, чсло не может быть отрецательным");
                        return;
                    }
                    result = Math.Sqrt(number1);
                    break;
                default:
                    Console.WriteLine("Ошибка, нет такой операции");
                    return;

            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Нажмите кнопку чтобы выйти");
            Console.ReadKey();
        }
    }
}
