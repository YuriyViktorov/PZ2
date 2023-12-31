﻿// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

//Вариант 1

Console.WriteLine ("Введите 3-х значное число:");
// Создаем переменную num И с консоли вводим ее значение.  
// При этом сразу проверяем на null и конвертируем  в int
int num = int.Parse(Console.ReadLine()??"0");

// вычисляем разрядность введенного числа c помощью десятичного логарифма
double digit = Math.Log10(num);
// Конвертирую double -> int и отбрасываю дробную часть
digit = (int)digit;

// Проверка,  что пользователь ввел 3-х значное число:
if (digit == 2)
{
    // отсекаем последнюю цифру числа
    int result = num / 10;
    // получаем вторую цифру числа
    result = result%10;
    // Выводим результат в консоль
    Console.WriteLine ("Вторая цифра числа: " + num + " равна: " + result);
}
else
{
    Console.WriteLine ("Введенное число не 3-х значное!!!");
    Console.WriteLine ("Введите 3-х значное!!! число!!!");
}
