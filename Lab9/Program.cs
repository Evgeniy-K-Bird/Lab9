using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.Write("Введите целое число. Х=");
            int x=0;
            bool errx = true;
            int y = 0;
            bool erry = true;
            while (errx)
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                    errx = false;
                }
                catch
                {
                    Console.Write("Ошибка! Попробуйте еще раз. Вводите только целое число. Х=");

                }
            }
            Console.Write("Введите целое число. У=");
            while (erry)
            {
                try
                {
                    y = int.Parse(Console.ReadLine());
                    erry = false;
                }
                catch
                {
                    Console.Write("Ошибка! Попробуйте еще раз. Вводите только целое число. У=");

                }
            }
            Console.WriteLine("Введите код операции:");
            Console.WriteLine("\t 1 - сложение");
            Console.WriteLine("\t 2 - вычитание");
            Console.WriteLine("\t 3 - произведение");
            Console.WriteLine("\t 4 - частное");
            Console.Write("Ваш выбор: ");
            int o = 0;
            bool erro = true;
            while (erro)
            {
                try
                {
                    o = int.Parse(Console.ReadLine());
                    erro = false;
                }
                catch
                {
                    Console.Write("Ошибка! Попробуйте еще раз. Введите только цело число:");

                }
            }
            int itog = 0;
            switch (o)
            {
                case 1:
                    {
                        itog = x + y;
                        Console.WriteLine("Результат = {0}",itog);
                        break;
                    }
                case 2:
                    {
                        itog = x - y;
                        Console.WriteLine("Результат = {0}", itog);
                        break;
                    }
                case 3:
                    {
                        itog = x * y;
                        Console.WriteLine("Результат = {0}", itog);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            itog = x / y;
                            Console.WriteLine("Результат = {0}", itog);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Нет операции с указанным номером");
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
