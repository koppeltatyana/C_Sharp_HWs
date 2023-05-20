Console.Clear();
System.Console.Write("Enter first number: ");
int num_1 = int.Parse(Console.ReadLine());
System.Console.Write("Enter second number: ");
int num_2 = int.Parse(Console.ReadLine());

if (num_1 > num_2) {
    System.Console.WriteLine($"Max number is {num_1}");
} else {
    System.Console.WriteLine($"Max number is {num_2}");
}
