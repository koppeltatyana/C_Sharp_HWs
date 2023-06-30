// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.Write("Введите размерность двумерного массива через пробел: ");
int[] arraySize = GetIntArrayFromString(expectedSize: 2);

int[,] spiralArray = FillSpiralArray(arraySize[0], arraySize[1]);
System.Console.WriteLine("\"Спиральный\" массив: ");
PrintArray(spiralArray); PrintEmptyString();

int[,] FillSpiralArray(int m, int n) {
    int[,] spiralArray = new int[m, n];

    int maxX = m, maxY = n - 1;
    int dirX = 1, dirY = 1;

    int x = -1, y = 0;
    int val = 1;

    while ((maxX >= 0) && (maxY >= 0)) 
    {
        for (int xValue = 1; xValue <= maxX; xValue++) {
            spiralArray[x + dirX * xValue, y] = val;
            val++;
        }
        x = x + dirX * maxX;
        dirX = -dirX;
        maxX--;

        for (int yValue = 1; yValue <= maxY; yValue++) {
            spiralArray[x, y + dirY * yValue] = val;
            val++;
        }
        y = y + dirY * maxY;
        dirY = -dirY;
        maxY--;
    }
    return spiralArray;
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(1); i++) {
        for (int j = 0; j < array.GetLength(0); j++) {
            if (array[j, i] < 10) System.Console.Write(String.Format("{0, 5}", $"0{array[j, i]}"));
            else System.Console.Write(String.Format("{0, 5}", array[j, i]));
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
