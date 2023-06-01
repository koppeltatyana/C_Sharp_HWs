// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void BeautifullyPrintArray(int[] array) {
    System.Console.WriteLine($"Ваш массив: [{String.Join(", ", array)}]");
}

int[] RandomArray(int array_size = 8) {
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
            string str_arr = System.Console.ReadLine();
            your_array = Array.ConvertAll(str_arr.Split(), int.Parse);
            if (your_array.Length == arr_size) break;
            else {
                System.Console.WriteLine();
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
