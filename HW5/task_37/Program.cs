// Задача 37: Найдмте произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и тд.
// Результат запишите в новом массиве.
// [1, 2, 3, 4, 5] -> 5 8 3
// [6, 7, 3, 6] -> 36 21

Console.Clear();
System.Console.Write("Введите размерность массива: ");
int arr_size = int.Parse(System.Console.ReadLine());

int[] random_array = GetRandomArray(array_size: arr_size, min_value: 1, max_value: 9);
System.Console.WriteLine($"Массив случайных чисел: [{String.Join(", ", random_array)}]");

int[] new_array = GetNewArray(array: random_array); PrintEmptyString();
System.Console.WriteLine($"Массив произведений пар чисел: [{String.Join(", ", new_array)}]");

/*----------------------- РЕАЛИЗАЦИЯ МЕТОДОВ -----------------------*/
int[] GetRandomArray(int array_size, int min_value = 100, int max_value = 1000) {
    int[] result = new int[array_size];
    for (int i = 0; i < array_size; i++) {
        result[i] = new Random().Next(min_value, max_value);
    }
    return result;
}

int[] GetNewArray(int[] array) {
    int[] result;
    if (array.Length % 2 == 1) result = new int[array.Length / 2 + 1];  // если длина входящего массива нечетная, добавляем единицу
    else result = new int[array.Length / 2];

    for (int i = 0; i < result.Length; i++) {
        if (array.Length % 2 == 1 && i == result.Length - 1) {  
            // если длина входящего массива нечетная, то серединный елемент не будет умножаться сам на себя
            result[i] = array[i];
        }
        else result[i] = array[i] * array[array.Length - i - 1];
    }
    return result;
}

void PrintEmptyString() {
    System.Console.WriteLine();
}
