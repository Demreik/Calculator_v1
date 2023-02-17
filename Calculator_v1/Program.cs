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
            while (true)
            {
                double number1 = 0.0;

                while (true)
                {
                    Console.Write("Введите первое число: ");
                    if (double.TryParse(Console.ReadLine(), out number1))
                    {
                        break;
                    }
                    Console.WriteLine("Ошибка, необходимо ввести число");
                }

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычетание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Квадратный корень");

                int choise = 0;

                while (true)
                {
                    Console.Write("Введите номер операции (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out choise))
                    {
                        break;
                    }
                    Console.WriteLine("Ошибка, необходимо ввести число");
                }

                double result = 0.0;
                double number2 = 0.0;


                switch (choise)
                {
                    case 1:
                        while (true)
                        {
                            Console.Write("Введите второе число: ");
                            if (double.TryParse(Console.ReadLine(), out number2))
                            {
                                result = number1 + number2;
                                break;
                            }
                            Console.WriteLine("Ошибка, необходимо ввести число");
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Write("Введите второе число: ");
                            if (double.TryParse(Console.ReadLine(), out number2))
                            {
                                result = number1 - number2;
                                break;
                            }
                            Console.WriteLine("Ошибка, необходимо ввести число");
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            Console.Write("Введите второе число: ");
                            if (double.TryParse(Console.ReadLine(), out number2))
                            {
                                result = number1 * number2;
                                break;
                            }
                            Console.WriteLine("Ошибка, необходимо ввести число");
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            Console.Write("Введите второе число: ");
                            if (double.TryParse(Console.ReadLine(), out number2))
                            {
                                if (number2 == 0)
                                {
                                    Console.WriteLine("Ошибка, нельзя делить на ноль");
                                    return;
                                }
                                result = number1 / number2;
                                break;
                            }
                            Console.WriteLine("Ошибка, необходимо ввести число");

                        }
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

                /*
                while(true)
                {
                    if(choise == 1)
                    {
                        while (true)
                        {
                            Console.Write("Введите второе число: ");
                            if (double.TryParse(Console.ReadLine(), out number2))
                            {
                                result = number1 + number2;
                                break;
                            }
                            Console.WriteLine("Ошибка, необходимо ввести число");
                        }

                    }

                    if (choise == 2)
                    {
                        while (true)
                        {
                            Console.Write("Введите второе число: ");
                            if (double.TryParse(Console.ReadLine(), out number2))
                            {
                                result = number1 - number2;
                                break;
                            }
                            Console.WriteLine("Ошибка, необходимо ввести число");
                        }

                    }

                    if (choise == 3)
                    {
                        while (true)
                        {
                            Console.Write("Введите второе число: ");
                            if (double.TryParse(Console.ReadLine(), out number2))
                            {
                                result = number1 * number2;
                                break;
                            }
                            Console.WriteLine("Ошибка, необходимо ввести число");
                        }

                    }

                    if (choise == 4)
                    {
                        while (true)
                        {
                            Console.Write("Введите второе число: ");
                            if (double.TryParse(Console.ReadLine(), out number2))
                            {
                                result = number1 / number2;
                                break;
                            }
                            Console.WriteLine("Ошибка, необходимо ввести число");
                        }

                    }

                    if (choise == 5)
                    {
                        if (number1 < 0)
                        {
                            Console.WriteLine("Ошибка, число не может быть отрицательным");
                            break;
                        }
                        result = Math.Sqrt(number1);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, нет такой операции");
                    }
                    Console.WriteLine($"Result: {result}");
                }
                */

                Console.WriteLine($"Результат: {result}");
                Console.Write("Нажмите R что бы воспользоваться калькулятором еще раз" +
                    ", или нажмите другую клавишу для выхода: ");
                string input = Console.ReadLine();
                if (input.ToUpper() != "R")
                {
                    break;
                }
            }
        }
    }
}
