// Задача 5.
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 278 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int number_of_digits(int num)
{
    while(num != 0)
    {
        num /= 10;
        counter+=1;
    }
return counter;

}

Console.WriteLine(number_of_digits(num));
