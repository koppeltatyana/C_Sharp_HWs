// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int M, N;
while (true) {
    Console.Write("Введите число M: ");
    M = int.Parse(System.Console.ReadLine());
    Console.Write("Введите число N: ");
    N = int.Parse(System.Console.ReadLine());

    if (N > M) break;
    System.Console.WriteLine("Число N должно быть больше числа M. Попробуйте еще раз.");
}
int elementsSum = GetSum(M, N);
System.Console.WriteLine(elementsSum);

int GetSum(int m, int n) {
    int sum = m;
    if (n - m == 0) return sum;
    else {
        sum += GetSum(m + 1, n);
    }
    return sum;
}
