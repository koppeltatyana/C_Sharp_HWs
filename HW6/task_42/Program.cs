// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
System.Console.Write("Введите через пробел коэффициенты (k1, b1) для первого уравнения y = k1 * x + b1: ");
string str_1 = System.Console.ReadLine();
double[] formula_1 = GetNumsArrayFromString(str_1);
System.Console.WriteLine($"Первое уравнение: y = {formula_1[0]} * x + {formula_1[1]}"); PrintEmptyString();

System.Console.Write("Введите через пробел коэффициенты (k2, b2) для первого уравнения y = k2 * x + b2: ");
string str_2 = System.Console.ReadLine();
double[] formula_2 = GetNumsArrayFromString(str_2);
System.Console.WriteLine($"Второе уравнение: y = {formula_2[0]} * x + {formula_2[1]}"); PrintEmptyString();

double[] intersection_point = GetIntersectionPoint(k1: formula_1[0], b1: formula_1[1], k2: formula_2[0], b2: formula_2[1]);
System.Console.WriteLine($"Прямые пересекаются в точке ({intersection_point[0]}, {intersection_point[1]})");


double[] GetNumsArrayFromString(string text) {
    double[] result = {};
    result = Array.ConvertAll(text.Trim().Split(), double.Parse);
    return result;
}

double[] GetIntersectionPoint(double k1, double b1, double k2, double b2) {
    double[] point = {(b1 - b2) / (k2 - k1), (b1 - b2) / (k2 - k1) * k1 + b1};
    return point;
}

void PrintEmptyString() {
    System.Console.WriteLine();
}
