// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
while (true) {
    System.Console.Write("Введите пятизначное число: ");
    int num = int.Parse(Console.ReadLine());
    if (Math.Abs(num) > 99999 || Math.Abs(num) < 10000) System.Console.WriteLine("Число должно быть пятизначным. Попробуйте еще раз!");
    else {
        if (num / 1000 == num % 10 * 10 + num % 100 / 10) System.Console.WriteLine($"Число {num} является палиндромом");
        else System.Console.WriteLine($"Число {num} НЕ является палиндромом");
        break;
    }
}
