// Задача: 
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

string firstDigit = Convert.ToString(number / 100);
string secondDigit = Convert.ToString(number % 10);

string result = firstDigit + secondDigit;
Console.WriteLine($"Изначальное число: {number} После операции: {result}");




