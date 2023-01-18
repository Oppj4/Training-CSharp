// Напишите программу, которая на вход принимает 2 числа
// и проверяет, является ли первое число квадратом второго

Console.Write("Enter first number: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA == (numB * numB))
{
    Console.WriteLine($"Yes, number {numA} is square number {numB}");
}
else 
{
    Console.WriteLine($"No, number {numA} is not square number {numB}");
}
