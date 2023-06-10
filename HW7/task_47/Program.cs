// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
System.Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов в массиве: ");
int m = int.Parse(System.Console.ReadLine());
PrintEmptyString();
double[,] randomArray = GetRandomArray(n, m);
PrintArray(randomArray);

double[,] GetRandomArray(int n, int m) {
    double[,] array = new double[n, m];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
        }
    }
    return array;
}

void PrintArray(double[,] array) {
    System.Console.WriteLine("Массив: ");
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintEmptyString() {
    System.Console.WriteLine();
}
