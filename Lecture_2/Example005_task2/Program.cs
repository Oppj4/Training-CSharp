// Задача: 
// Написать программу, которая 
// Выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.


int number = new Random().Next(10, 100);
int result = 0;

int firstDigit = number / 10;
int secondDigit = number % 10;


if(firstDigit >= secondDigit) result = firstDigit;
else result = secondDigit;


Console.WriteLine($"Самая большая цифра числа {number} = {result}");