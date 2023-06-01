// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumsSum(int num) {
    int nums_sum = 0;
    while (Math.Abs(num) > 0) {
        nums_sum += Math.Abs(num) % 10;
        num /= 10;
    }
    return nums_sum;
}

Console.Clear();
System.Console.Write("Введите число: ");
int num = int.Parse(System.Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа {num} равна {GetNumsSum(num)}");
