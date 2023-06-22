// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int m, n;
while (true) {
    Console.Write("Введите число n: ");
    n = int.Parse(System.Console.ReadLine());
    Console.Write("Введите число m: ");
    m = int.Parse(System.Console.ReadLine());

    if (n > 0 && m > 0) break;
    System.Console.WriteLine("Числа n и m должны быть больше 0. Попробуйте еще раз.");
}
int ackResult = GetAck(m, n);
System.Console.WriteLine(ackResult);

int GetAck(int n, int m) {
    if (n == 0) return m + 1;
    else if (m == 0) return GetAck(n - 1, 1);
    else return GetAck(n - 1, GetAck(n, m - 1));
}
