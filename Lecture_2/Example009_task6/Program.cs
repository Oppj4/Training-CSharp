// Задача: 
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого.
// 5, 25 -> да 
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

bool isDiv1 = numA % numB == 0 ? true : false;
bool isDiv2 = numB % numA == 0 ? true : false;

string result = "";
if (isDiv1 || isDiv2) result = $"Одно из чисел [{numA} {numB}] кратно другому.";
else result = "Ни одно из чисел [{numA, numB} не кратно друг другу.";

Console.WriteLine(result);