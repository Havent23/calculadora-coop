using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;
            char op;

            Console.Write("Primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Operador: ");
            op = char.Parse(Console.ReadLine());

            if (op == char.Parse("+")){
                res = num1 + num2;
            } else if (op == char.Parse("-")){
                res = num1 - num2;
            } else if (op == char.Parse("*")){
                res = num1 * num2;
            } else {
                res = num1 / num2;
            }
            Console.Write(res);
        }
    }
}