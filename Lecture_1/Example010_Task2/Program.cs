// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

string day = "";

if (num == 1) day = "Понедельник";
else if (num == 2) day = "Вторник";
else if (num == 3) day = "Среда";
else if (num == 4) day = "Четверг";
else if (num == 5) day = "Пятница";
else if (num == 6) day = "Суббота";
else if (num == 7) day = "Воскресенье";
else day = "Неверное число";

Console.WriteLine(day);
