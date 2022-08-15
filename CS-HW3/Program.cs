using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Printer.Library.PrintInfo(3);

            bool f = true;

            while (f)
            {
                Console.WriteLine("==================================================================");
                Console.WriteLine("Мои задачи");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("==================================================================");

                Console.Write("Введите номер задачи: ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: \n");
                }
                else
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Выберите Работу комплексных чисел: 1 - работа структуры. 2 - работа класса");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Complex complex1;
                                    complex1.re = 9;
                                    complex1.im = 5;

                                    Complex complex2;
                                    complex2.re = 7;
                                    complex2.im = 7;

                                    Console.WriteLine("Pезультат работы структуры:");
                                    Complex result = complex1.Plus(complex2);
                                    Console.WriteLine("Результом операции сложения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                                        + result.ToString());
                                    result = complex1.Multi(complex2);
                                    Console.WriteLine("Результом операции умножения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                                       + result.ToString());
                                    result = complex1.Minus(complex2);
                                    Console.WriteLine("Результом операции вычитания чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                                       + result.ToString());

                                    break;
                                case 2:
                                    Console.WriteLine("Pезультат работы класса:");
                                    NewComlex ccomplex1 = new NewComlex(5, 3);
                                    NewComlex ccomplex2 = new NewComlex(8, 5);
                                    ccomplex2.Im = 5;
                                    NewComlex cresult = ccomplex1.Plus(ccomplex2);
                                    Console.WriteLine("Результом операции сложения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                                        + cresult.ToString());
                                    cresult = ccomplex1.Multi(ccomplex2);
                                    Console.WriteLine("Результом операции умножения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                                       + cresult.ToString());
                                    cresult = ccomplex1.Minus(ccomplex2);
                                    Console.WriteLine("Результом операции вычитания чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                                       + cresult.ToString());

                                    break;
                                default:
                                    Console.WriteLine("Выход");
                                    break;

                            }
                            break;

                        case 2:
                            ZeroNum();
                            break;

                        case 0:
                            f = false;
                            break;

                        default:
                            Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                            break;
                    }
                }
            }
        }

        private static void ZeroNum()
        {
            int b = 0;
            while (true)
            {
                Console.Write("Введите число (чтобы завершить подсчет введите 0) : ");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: \n");
                }
                else
                {
                    if (a != 0)
                    {
                        if (a % 2 == 0 || a < 0)
                        { }
                        else
                            b += a;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            Console.WriteLine("Сумма всех ваших нечетных положительных чисел: " + b);
            Console.ReadKey();
        }
    }
}
