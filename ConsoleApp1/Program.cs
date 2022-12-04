using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FuncMath exp = new FuncMath();
            exp.plus(1, 1);
            exp.multiplication(2, 3);
            exp.factorial(-1); // при данном значении будет выведена ошибка
            exp.division(1, 0); // ошибка - деление на ноль
        }
    }
}
