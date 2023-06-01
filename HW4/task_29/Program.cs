// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void WriteEmptyString() {
    // вывести пустую строку
    System.Console.WriteLine();
}

void BeautifullyPrintArray(int[] array) {
    // красиво вывести массив
    WriteEmptyString();
    System.Console.WriteLine($"Ваш массив: [{String.Join(", ", array)}]");
    WriteEmptyString();
}

int[] RandomArray(int array_size = 8) {
    // сгенерировать массив случайных чисел от 0 до 99 заданной длины 
    int[] result = new int[array_size];
    for (int i = 0; i < array_size; i++) result[i] = new Random().Next(100);
    return result;
}

Console.Clear();
System.Console.Write($"Хотите рандомный массив? (y/n) ");
string answer = System.Console.ReadLine();
System.Console.Write($"Введите длину массива: ");
int arr_size = int.Parse(System.Console.ReadLine());

switch (answer) 
{
    case "y":
        int[] random_array = RandomArray(array_size: arr_size);
        BeautifullyPrintArray(random_array);
        break;

    case "n":
        int[] your_array = new int[arr_size];
        while (true) {
            System.Console.Write($"Введите массив длиной {arr_size} через пробел: ");
            string str_arr = System.Console.ReadLine().Trim();
            your_array = Array.ConvertAll(str_arr.Split(), int.Parse);
            if (your_array.Length == arr_size) break;
            else {
                WriteEmptyString();
                System.Console.WriteLine($"Вы ввели неверное количество элементов массива. Требуется - {arr_size}. Попробуйте снова.");
            }
        }   
        BeautifullyPrintArray(your_array);
        break;

    default:
        System.Console.WriteLine("Вы ввели не \"y\", и не \"n\", когда вас спрашивали про рандомность массива, поэтому был создан рандомный массив в качестве утешительного приза.");
        int[] array = RandomArray(array_size: arr_size);
        BeautifullyPrintArray(array);
        break;
}
