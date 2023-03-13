// Задача 4.
// Напишите программу, которая будет преобразовать
// десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());


int  DecimalToBinary(int num)
{
    int result = default;
    int mult = 1;
    while (num > 0)
    {
        result += num % 2 * mult; 
        num /= 2;
        mult *= 10;
    }

    return result;
}

Console.WriteLine(DecimalToBinary(num));