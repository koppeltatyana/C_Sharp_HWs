// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int[] FillCubesArray(int array_size) {
    int[] result = new int[array_size];
    for (int i = 1; i <= array_size; i++) result[i - 1] = i * i * i;
    return result;
}

while (true) {
    System.Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());

    if (N <= 0) System.Console.WriteLine("Необходимо ввести целое положительное число. Попробуйте еще раз.");
    else {
        int[] cubes_array = FillCubesArray(N);
        System.Console.WriteLine("Кубы: ");
        for (int i = 0; i < cubes_array.Length; i++) System.Console.WriteLine($"Число {i + 1} в кубе равно " + cubes_array[i]);
        break;
    }
}
