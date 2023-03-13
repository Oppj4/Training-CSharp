// Задача 3.
// Напишите программу, которая принимает
// на вход три числа и проверяет, может
// ли существовать треугольник с сторонами
// такой длины.

// P.S Теорема о неравенстве треугольника:
// каждая сторона треугольник меньше
// суммы двух других сторон.

Console.Write("Введите сторону треугольника А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону треугольника B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону треугольника C: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool isTriangle(int A, int B, int C)
{
    
    return ((A < B + C) && (B < A + C) && (C < A + B));

}

Console.WriteLine(isTriangle(numA, numB, numC) ? "Да" : "Нет");