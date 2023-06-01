// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int MyPow(int number, int degree) {
    int result = 1;
    for (int i = 1; i <= degree; i++) result *= number;
    return result;
}

Console.Clear();
System.Console.Write("Введите число, которое хотите возвести в степень: ");
int num = int.Parse(System.Console.ReadLine());
System.Console.Write($"Введите степень, в которую хотите возвести число {num}: ");
int degree = int.Parse(System.Console.ReadLine());
System.Console.WriteLine($"Число {num} в степени {degree} равно {MyPow(num, degree)}");
