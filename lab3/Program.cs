using System;
using MyClasses;



namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Clear();
            Language eng = new English();
            Console.WriteLine(eng.Alphabet());

            Language ger = new German();
            Console.WriteLine(ger.Alphabet());

            Language jp = new Japanese();
            Console.WriteLine(jp.Alphabet());

            Console.WriteLine($"English: {eng.Hello()}");
            Console.WriteLine($"Japanese: {jp.Hello()}");
            Console.WriteLine($"German: {ger.Hello()}");
        }
    }
}