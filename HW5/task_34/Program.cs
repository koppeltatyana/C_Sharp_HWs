// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
System.Console.Write("Введите размерность массива: ");
int arr_size = int.Parse(System.Console.ReadLine());

int[] random_array = GetRandomArray(array_size: arr_size);
int arr_even_num_count = GetEvenNumbersCount(array: random_array);

System.Console.WriteLine($"Массив случайных трехзначных чисел: [{String.Join(", ", random_array)}]");
System.Console.WriteLine($"Количество четных чисел в массиве -- {arr_even_num_count}");

int[] GetRandomArray(int array_size, int min_value = 100, int max_value = 1000) {
    int[] result = new int[array_size];
    for (int i = 0; i < array_size; i++) {
        result[i] = new Random().Next(min_value, max_value);
    }
    return result;
}

int GetEvenNumbersCount(int[] array) {
    int count = 0;
    foreach (int el in array) {
        if (el % 2 == 0) count += 1;
    }
    return count;
}
