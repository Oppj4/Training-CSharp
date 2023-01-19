// Задача: 
// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = "";

if(num == 0) result = "На ноль делить нельзя!";
else if (num % 7 == 0 && num % 23 == 0) result = $"Число {num} КРАТНО 7 и 23 одновременно"; 
else result = $"Число {num} НЕ КРАТНО 7 и 23 одновременно";

Console.WriteLine(result);