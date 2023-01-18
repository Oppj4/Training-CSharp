//Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые числа
// в диапозоне от -N до N
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int negativeNum = num - (num * 2);

while (negativeNum <= num)
{
    Console.Write(negativeNum + " ");
    negativeNum += 1;
}
