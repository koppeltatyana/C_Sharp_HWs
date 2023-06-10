// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите размерность двумерного массива через пробел: ");
int[] arraySize = GetIntArrayFromString(expectedSize: 2);
int[,] randomArray = GetRandomArray(arraySize[0], arraySize[1]);
PrintArray(randomArray);
double[] columnArrayAvg = GetArrayColumnAvg(randomArray);
System.Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join(", ", columnArrayAvg)}\n");


int[,] GetRandomArray(int n, int m, int minValue = 1, int maxValue = 10) {
    int[,] array = new int[n, m];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

double[] GetArrayColumnAvg(int[,] array) {
    double[] result = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++) {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++) {
            sum += array[j, i];
        }

        double avg = Math.Round(sum / array.GetLength(0), 3);
        result[i] = avg;
    }
    return result;
}

void PrintArray(int[,] array) {
    System.Console.WriteLine("\nМассив: ");
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] GetIntArrayFromString(int expectedSize) {
    while (true) {
        string text = System.Console.ReadLine().Trim();
        text = String.Join(" ", text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));
        
        if ((text.Split()).Length != expectedSize) {
            System.Console.WriteLine($"Вы ввели неверное количество чисел. Ожидается {expectedSize}. Попробуйте еще раз.");
        } else {
            return Array.ConvertAll(text.Split(), int.Parse);
        }
    }
}
