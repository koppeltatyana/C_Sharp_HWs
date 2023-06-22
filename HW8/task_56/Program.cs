// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
int[] arraySize;

while (true) {
    Console.Write("Введите размерность двумерного массива через пробел: ");
    arraySize = GetIntArrayFromString(expectedSize: 2);
    if (arraySize[0] != arraySize[1]) break;
    System.Console.WriteLine("Требуется задать прямоугольный массив. Кол-во строк должно быть не равно кол-ву столбцов. Попробуйте еще раз.");
    PrintEmptyString();
}

int[,] randomArray = RandomArray(arraySize[0], arraySize[1]);
System.Console.WriteLine("Массив: ");
PrintArray(randomArray); PrintEmptyString();

int arrayIndex = GetArrayRowMinSumIndex(randomArray);
System.Console.WriteLine($"Строка массива с наименьшей суммой элементов - {arrayIndex + 1}");

int[,] RandomArray(int m, int n, int minValue = -10, int maxValue = 10) {
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int GetArrayRowMinSumIndex(int[,] array) {
    int rowIndex = 0;
    int rowSum = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        int currentRowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++) {
            currentRowSum += array[i, j];
        }
        if (currentRowSum < rowSum) {
            rowSum = currentRowSum;
            rowIndex = i;
        }
    }
    return rowIndex;
}

void PrintArray(int[,] array) {
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
