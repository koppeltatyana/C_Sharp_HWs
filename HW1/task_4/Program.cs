Console.Clear();
System.Console.Write("Enter first number: ");
int num_1 = int.Parse(Console.ReadLine());
System.Console.Write("Enter second number: ");
int num_2 = int.Parse(Console.ReadLine());
System.Console.Write("Enter third number: ");
int num_3 = int.Parse(Console.ReadLine());

if (num_1 > num_2 && num_1 > num_3) {
    System.Console.WriteLine($"Max number is {num_1}");
} else if (num_2 > num_1 && num_2 > num_3) {
    System.Console.WriteLine($"Max number is {num_2}");
} else if (num_3 > num_1 && num_3 > num_2) {
    System.Console.WriteLine($"Max number is {num_3}");
}
