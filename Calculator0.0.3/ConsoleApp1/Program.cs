using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ver = "0.3";
            Console.WriteLine($"Калькулятор версии {ver}\nВремя { DateTime.Now}");
            Console.WriteLine("Выберите что будем делать?\nСкладывать: +\nВычитать: -\nУмножать: *\nДелить: / ");
            string ViborInversii = Console.ReadLine();
            switch (ViborInversii)
            {
                case "+":
                    Console.WriteLine("Вы выбрали сложения\nВведите пожалуйста комбинацию цифр");
                    long z = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Число {z} записано, введите второе число");
                    long x = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Ответ:{z + x}");
                    break;
                case "-":
                    Console.WriteLine("Вы выбрали вычитания\nВведите пожалуйста комбинацию цифр");
                    long d = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Число {d} записано, введите второе число");
                    long f = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Ответ:{d - f}");
                    break;
                case "*":
                    Console.WriteLine("Вы выбрали умножение\nВведите пожалуйста комбинацию цифр");
                    long e = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Число {e} записано, введите второе число");
                    long a = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Ответ:{e * a}");
                    break;
                case "/":
                    Console.WriteLine("Вы выбрали деление\nВведите пожалуйста комбинацию цифр");
                    float l = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Число {l} записано, введите второе число");
                    float n = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"Ответ:{l / n}");
                    break;
                default:
                    Console.WriteLine("Произошла критическая ошибка!!!\nПросьба перезапустить программу");
                    break;                    
            }
            Console.WriteLine("\nPress key...");
            Console.ReadKey();
        } 
    }
} 




