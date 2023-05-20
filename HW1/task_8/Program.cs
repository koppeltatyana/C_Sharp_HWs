// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
System.Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

if (N < 1) {
    System.Console.WriteLine("Число N должно быть больше 1");
    return;
}

int count = 1;
while (count <= N) {
    if (count % 2 == 0) System.Console.WriteLine(count);
    count++;
}
