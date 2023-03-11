// Задача 6.
// Напишите программу, которая принимает
// на вход число N и выдаёт произведение
// чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0) num *= -1;

// Альтернатива.
// int multiply = 1;
// for(int i = 1; i <= num; i++)
// {
//     multiply *= i;
// }
// Console.WriteLine(multiply);

double multiply(int n)
{
    if(n == 1) return 1;
    else return n * multiply(n-1);
}

Console.WriteLine(multiply(num));




