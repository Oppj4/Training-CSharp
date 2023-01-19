// Задача: 
// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли
// второе число кратным первому. Если число 2
// не кратно числу 1, то программа выводит остатот
// от деления

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("Введите 1 число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA % numB == 0) Console.WriteLine($"Число {numB} кратно числу {numA}");
else Console.WriteLine($"Число {numB} не кратно числу {numA}, остаток {numA % numB}");