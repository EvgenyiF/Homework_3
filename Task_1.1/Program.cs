﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
M: Console.Write("Введите 5-ти значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 100000 || a < 10000)
{
    Console.WriteLine($"Число {a} не является 5-ти значным, попробуйте ввести заного");
    goto M;
}
int[] array1 = new int[5]; // объявляем массив
double b = 0; // переменная для переворнутого числа
int i = 0; // переменные a1 и i для перевода числа в массив
int a1 = a;
for (int count = 0; count < array1.Length; count++)
{
    i = a1 % 10;       // 15,16,17 перевод числа а в массив с переворотом
    array1[count] = i;
    a1 /= 10;
    b = b + array1[count] * Math.Pow(10, 5 - count - 1); // преобразование массива в число
}
if (a == b)
{
    Console.WriteLine($"Число {a} равно {b} и является полиндромом");
}
else
{
    Console.WriteLine($"Число {a} не равно {b} и не является полиндромом");
}