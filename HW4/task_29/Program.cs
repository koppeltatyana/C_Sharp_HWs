// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void BeautifullyPrintArray(int[] array, string sep = " ") {
    System.Console.WriteLine($"{String.Join($" {sep} ", array)}");
}

int[] RandomArray(int array_size) {
    int[] result = new int[array_size];
    for (int i = 0; i < array_size; i++) result[i] = new Random().Next(100);
    return result;
}

Console.Clear();
System.Console.Write("Введите размерность массива: ");
int arr_size = int.Parse(System.Console.ReadLine());
System.Console.Write("Введите разделитель: ");
string sep = System.Console.ReadLine();

int[] array = RandomArray(arr_size);
System.Console.WriteLine($"Массив: ");
BeautifullyPrintArray(array, sep);
