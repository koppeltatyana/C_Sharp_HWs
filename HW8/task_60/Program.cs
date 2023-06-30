// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Введите размерность трехмерного массива через пробел: ");
int[] arraySize = GetIntArrayFromString(expectedSize: 3);

int[,,] array = GetArray(arraySize, 10, 99);
PrintArray(array); PrintEmptyString();

int[,,] GetArray(int[] arraySize, int minValue, int maxValue) {
    int[,,] resultArray = new int[arraySize[0], arraySize[1], arraySize[2]];

    for (int i = 0; i < resultArray.GetLength(0); i++) {
        for (int j = 0; j < resultArray.GetLength(1); j++) {
            for (int k = 0; k < resultArray.GetLength(2); k++) {
                int value;
                while (true) {
                    value = new Random().Next(minValue, maxValue + 1);
                    if (!IsElementInArray(resultArray, value)) break;
                }
                resultArray[i, j, k] = value;
            }
        }
    }
    return resultArray;
}

bool IsElementInArray(int[,,] array, int num) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; i < array.GetLength(1); i++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                if (array[i, j, k] == num) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                System.Console.Write($"{array[i, j, k]} ({i}, {j}, {k})     ");
            }
            System.Console.WriteLine();
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
