﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трёхзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int secondDigit = (number / 10) % 10;

        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }
}