using System;

class Program
{
    static void Main(string[] args)
    {
        //Задача 10.
        int number = Input ("Введите число");
        if (number>= 100 && number < 1000) Console.WriteLine($"Вторая цифра числа: {number / 10 % 10}");
        else Console.WriteLine("Число не трехзначное");
    }
}
