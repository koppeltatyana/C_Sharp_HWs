// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

double MyPow(double number, double degree) {
    double result = 1;
    for (int i = 1; i <= Math.Abs(degree); i++) result *= number;
    if (degree < 0) return 1 / result;
    else return result;
}

System.Console.Write("Введите число, которое хотите возвести в степень: ");
double num = double.Parse(System.Console.ReadLine());
System.Console.Write($"Введите степень, в которую хотите возвести число {num}: ");
double degree = double.Parse(System.Console.ReadLine());
System.Console.WriteLine($"Число {num} в степени {degree} равно {MyPow(num, degree)}");
