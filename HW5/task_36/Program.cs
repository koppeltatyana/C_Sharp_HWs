﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
System.Console.Write("Введите размерность массива: ");
int arr_size = int.Parse(System.Console.ReadLine());

int[] random_array = GetRandomArray(array_size: arr_size);
System.Console.WriteLine($"Массив случайных чисел длиной {arr_size}: [{String.Join(", ", random_array)}]");

int odd_position_elements_sum = GetSumOddPositionElements(array: random_array);
PrintEmptyString();
System.Console.WriteLine($"Сумма значений массива на нечетных позициях равно {odd_position_elements_sum}");

/*----------------------- РЕАЛИЗАЦИЯ МЕТОДОВ -----------------------*/
int[] GetRandomArray(int array_size, int min_value = -100, int max_value = 100) {
    int[] result = new int[array_size];
    for (int i = 0; i < array_size; i++) {
        result[i] = new Random().Next(min_value, max_value);
    }
    return result;
}

int GetSumOddPositionElements(int[] array) {
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
}

void PrintEmptyString() {
    System.Console.WriteLine();
}

/*------------- пример запуска (массив четной величины) ------------*/
/*
Введите размерность массива: 12
Массив случайных чисел длиной 12: [-36, -46, -66, 78, -15, -6, -25, 20, 33, 80, 0, -2]

Сумма значений массива на нечетных позициях равно 124
*/

/*------------ пример запуска (массив нечетной величины) -----------*/
/* 
Введите размерность массива: 11
Массив случайных чисел длиной 11: [-13, 15, 87, -34, -54, -99, 65, 5, 87, 9, -62]

Сумма значений массива на нечетных позициях равно -104 
*/
