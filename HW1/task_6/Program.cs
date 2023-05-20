Console.Clear();
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0) {
    System.Console.WriteLine($"Число {num} делится на 2 без остатка");
} else {
    System.Console.WriteLine($"Число {num} делится на 2 с остатком");
}
