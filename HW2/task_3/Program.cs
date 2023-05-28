// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
while (true){
    System.Console.Write("Введите число дня недели: ");
    int week_day = int.Parse(Console.ReadLine());
    if (week_day < 1 || week_day > 7) System.Console.WriteLine("Номера дней недели находятся в диапазоне [1, 7]. Попробуйте снова!");
    else if (week_day == 6 || week_day == 7) System.Console.WriteLine("Да");
    else {
        System.Console.WriteLine("Нет");
        break;
    }
}
