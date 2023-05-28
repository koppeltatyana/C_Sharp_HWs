// На столе лежат n монеток. Некоторые из них лежат вверх решкой, 
// а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть, 
// чтобы все монетки были повернуты вверх одной и той же стороной.
// 1 - Решка
// 0 - Орел

Console.Clear();
int[] FillBiteArray(int array_size) {
    // заполнить массив размера array_size нулями и единицами
    int[] result = new int[array_size];
    for (int i = 0; i < array_size; i++) result[i] = new Random().Next(0, 2);
    return result;
}

int CountNumberInArray(int num, int[] array) {
    // посчитать количество вхождений числа num в массив array
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == num) count++;
    }
    string def;
    if (num == 0) def = "Орел";
    else def = "Решка";

    System.Console.WriteLine($"Число {num} ({def}) встречается в массиве {count} раз");
    return count;
}

void WriteArray(int[] array) {
    // вывести массив в консоль
    System.Console.Write("Массив монеток: ");
    for (int i = 0; i < array.Length; i++) System.Console.Write(array[i] + " ");
    System.Console.WriteLine();
}

void WriteEmptyString() {
    // вывести пустую строку
    System.Console.WriteLine();
}

while (true) {
    System.Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());

    if (N <= 0) 
    {
        System.Console.WriteLine("Необходимо ввести целое положительное число. Попробуйте еще раз.");
    } else {
        int[] bites_array = FillBiteArray(N);  // заполнили массив рандомными решками и орлами
        WriteArray(bites_array); // печататем массив монет

        WriteEmptyString();
        int zero_count = CountNumberInArray(num: 0, array: bites_array);  // получить кол-во вхождений орлов в массиве
        int one_count = CountNumberInArray(num: 1, array: bites_array);  // получить кол-во вхождений решек в массиве
        WriteEmptyString();

        if (zero_count == one_count) System.Console.WriteLine("Можете переворачивать любые одинаковые монеты, так как количество монет с орлом и решкой одинаковое");
        else if (zero_count == 0 || one_count == 0) System.Console.WriteLine("О, чудо! Все монетки лежат одной стороной! Вероятность 50% на вас не работает :)");
        else if (zero_count < one_count) {
            System.Console.WriteLine($"Необходимо перевернуть {zero_count} монет, лежавших вверх орлом");
        } else {
            System.Console.WriteLine($"Необходимо перевернуть {bites_array.Length - zero_count} монет, лежавших вверх решкой");
        }
        break;
    }
}

