﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(System.Console.ReadLine());
System.Console.Write($"N = {N} => ");
System.Console.WriteLine(DecrementNum(N));

string DecrementNum(int n) {
    if (n == 1) return $"{n}";
    string s = $"{n} " + DecrementNum(n - 1);
    return s;
}
