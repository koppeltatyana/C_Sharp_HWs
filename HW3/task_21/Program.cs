// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int[] FillRandomPointArray(int array_length) {
    int[] result = new int[array_length];
    for (int i = 0; i < array_length; i++) result[i] = new Random().Next(-999, 999);
    return result;
}

int[] point_1 = FillRandomPointArray(3);
int[] point_2 = FillRandomPointArray(3);

double result = Math.Sqrt(Math.Pow(point_1[0] - point_2[0], 2) + Math.Pow(point_1[1] - point_2[1], 2) + Math.Pow(point_1[2] - point_2[2], 2));
System.Console.WriteLine(
    $"Расстояние между точками ({point_1[0]}, {point_1[1]}, {point_1[2]}) и ({point_2[0]}, {point_2[1]}, {point_2[2]}) равно: " + result);
