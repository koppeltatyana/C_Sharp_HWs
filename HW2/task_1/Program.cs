// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
while (true) {
    System.Console.Write("Введите трехзначное число: ");
    int num = int.Parse(Console.ReadLine());
    if (num > 999 || num < -999) System.Console.WriteLine("Число должно быть трехзначным!");
    else {
        System.Console.WriteLine($"Вторая цифра числа {num} -> {num / 10 % 10}");
        break;
    }
}
