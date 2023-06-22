// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите размерность двумерного массива через пробел: ");
int[] arraySize = GetIntArrayFromString(expectedSize: 2);
int[,] randomArray = RandomArray(arraySize[0], arraySize[1]);
System.Console.WriteLine("Изначальный массив: ");
PrintArray(randomArray); PrintEmptyString();

int[,] rowsSortedArray = SortArrayRows(randomArray);
System.Console.WriteLine("Массив с отсортированными по убыванию строками: ");
PrintArray(rowsSortedArray); PrintEmptyString();

int[,] RandomArray(int m, int n, int minValue = -10, int maxValue = 10) {
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int[,] SortArrayRows(int[,] array) {
    int[,] resultArray = CopyArray(array);

    // проход по строкам
    for (int i = 0; i < resultArray.GetLength(0); i++) {
        int temp;
 
        // сортировка строк
        for (int j = 0; j < resultArray.GetLength(1) - 1; j++)

            // сравнение последующих элементов строки и до конца строки
            for (int k = j + 1; k < resultArray.GetLength(1); k++)

                if (resultArray[i, j] < resultArray[i, k]) {
                    // свап элементов
                    temp = resultArray[i, j];
                    resultArray[i, j] = resultArray[i, k];
                    resultArray[i, k] = temp;
                }
        }
    return resultArray;
}

int[,] CopyArray(int[,] array) {
    int[,] copiedArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            copiedArray[i, j] = array[i, j];
        }
    }
    return copiedArray;
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            System.Console.Write($"{array[i, j], 5}");
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
