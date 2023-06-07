// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
System.Console.Write("Введите числа через пробел: ");
string str = System.Console.ReadLine();
int[] nums = GetNumsArrayFromString(str);
PrintArray(nums);
int array_positive_count = GetArrayPositiveElementsCount(nums);
System.Console.WriteLine($"Количество положительных чисел в массиве - {array_positive_count}");

int[] GetNumsArrayFromString(string text) {
    int[] result = {};
    result = Array.ConvertAll(text.Trim().Split(), int.Parse);
    return result;
}

int GetArrayPositiveElementsCount(int[] array) {
    int count = 0;
    foreach (int el in array) {
        if (el > 0) count++;
    }
    return count;
}

void PrintArray(int[] array) {
    System.Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
}
