// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите размерность двумерного массива через пробел: ");
int[] arraySize = GetIntArrayFromString(expectedSize: 2);
PrintEmptyString();
int[,] randomArray = GetRandomArray(arraySize[0], arraySize[1]);
PrintArray(randomArray);
PrintEmptyString();

System.Console.Write("Введите индексы элемента через пробел: ");
int[] arrayElementIndexes = GetIntArrayFromString(expectedSize: 2);
System.Console.WriteLine(
    $"randomArray[{arrayElementIndexes[0]}][{arrayElementIndexes[1]}] -> {GetArrayElement(arrayElementIndexes, randomArray)}\n");


int[,] GetRandomArray(int n, int m, int minValue = 1, int maxValue = 10) {
    int[,] array = new int[n, m];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

string GetArrayElement(int[] elIndexes, int[,] array) {
    if (elIndexes[0] >= array.GetLength(0) || elIndexes[1] >= array.GetLength(1)) {
        return $"Элемента [{elIndexes[0]}, {elIndexes[1]}] нет в массиве";
    } else {
        return $"{array[elIndexes[0], elIndexes[1]]}";
    }
}

void PrintArray(int[,] array) {
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
