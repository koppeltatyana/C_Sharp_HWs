// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
System.Console.Write("Введите размерность массива: ");
int arr_size = int.Parse(System.Console.ReadLine());

double[] random_array = GetRandomDoubleArray(array_size: arr_size);
System.Console.WriteLine($"Массив случайных вещественных чисел длиной {arr_size}: [{String.Join(", ", random_array)}]");
PrintEmptyString();
double[] array_max_min = GetArrayMaxMin(array: random_array);
System.Console.WriteLine(
    $"Разница между максимальным ({array_max_min[0]}) и минимальным ({array_max_min[1]}) значениями равно {array_max_min[0] - array_max_min[1]}");

/*----------------------- РЕАЛИЗАЦИЯ МЕТОДОВ -----------------------*/
double[] GetRandomDoubleArray(int array_size) {
    double[] result = new double[array_size];

    int[] num_sign = {-1, 1};
    for (int i = 0; i < array_size; i++) {
        result[i] = 
        Math.Round(
            new Random().NextDouble() * new Random().Next(1, 20) * num_sign[new Random().Next(0, 2)], 3
        ); // домножаем на произвольное число, так как NextDouble генерирует число от 0 до 1
    }
    return result;
}

double[] GetArrayMaxMin(double[] array) {
    double[] result = new double[2];
    result[0] = array[0];  // первое число будет max
    result[1] = array[0];  // второе число будет min
    
    foreach (double el in array) {
        if (el > result[0]) result[0] = el;
        if (el < result[1]) result[1] = el;
    }
    return result;
}

void PrintEmptyString() {
    System.Console.WriteLine();
}

/*------------------------- пример запуска -------------------------*/
/*
Введите размерность массива: 7
Массив случайных вещественных чисел длиной 7: [1.034, -11.374, -8.271, 10.49, 8.202, -3.731, 3.246]

Разница между максимальным (10.49) и минимальным (-11.374) значениями равно 21.864
*/
