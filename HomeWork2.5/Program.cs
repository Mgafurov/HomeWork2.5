using System;

class HomeWork
{
    static void Main()
    {
        Console.WriteLine("Введите значение переменной x : ");
        float x = float.Parse(Console.ReadLine());
        float result = (x * x * x / 3)  + (x * x * x * x * x / 5);
        Console.WriteLine("Результат : " + result);
        Console.ReadKey();
    }
}
