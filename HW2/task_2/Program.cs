// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (Math.Abs(num) < 100) 
    System.Console.WriteLine($"{num} -> третьей цифры нет");
else if (Math.Abs(num) < 1000) 
    System.Console.WriteLine($"{num} -> {Math.Abs(num % 10)}"); 
else {
    int tmp = num;
    while (Math.Abs(tmp) > 999) tmp = tmp / 10;
    System.Console.WriteLine($"{num} -> {Math.Abs(tmp % 10)}");
}

