/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();
int[] arraySizeA;
int[] arraySizeB;

while (true) {
    Console.Write("Введите размерность первой матрицы через пробел: ");
    arraySizeA = GetIntArrayFromString(expectedSize: 2);

    Console.Write("Введите размерность второй матрицы через пробел: ");
    arraySizeB = GetIntArrayFromString(expectedSize: 2);

    if (arraySizeA[1] == arraySizeB[0]) break;
    System.Console.WriteLine(
        "Для умножаения матриц необходимо чтобы число столбцов первой матрицы совпадало с числом строк второй матрицы. Попробуйте еще раз.");
    PrintEmptyString();
}

int[,] randomArrayA = RandomArray(arraySizeA[0], arraySizeA[1]);
System.Console.WriteLine("Матрица A: ");
PrintArray(randomArrayA); PrintEmptyString();

int[,] randomArrayB = RandomArray(arraySizeB[0], arraySizeB[1]);
System.Console.WriteLine("Матрица B: ");
PrintArray(randomArrayB); PrintEmptyString();

int[,] multArrays = MultArrays(randomArrayA, randomArrayB);
System.Console.WriteLine("Результирующая матрица: ");
PrintArray(multArrays); PrintEmptyString();

int[,] RandomArray(int m, int n, int minValue = -5, int maxValue = 5) {
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

int[,] MultArrays(int[,] arrayA, int[,] arrayB) {
    int[,] resultArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                resultArray[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return resultArray;
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
