// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
while (true) {
    System.Console.Write("Введите трехзначное число: ");
    int num = int.Parse(Console.ReadLine());
    if (Math.Abs(num) > 999 || Math.Abs(num) < 100) System.Console.WriteLine("Число должно быть трехзначным!");
    else {
        System.Console.WriteLine($"Вторая цифра числа {num} -> {Math.Abs(num / 10 % 10)}");
        break;
    }
}
