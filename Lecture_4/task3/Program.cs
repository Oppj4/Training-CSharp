Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

double factorial(int n)
{
    if(n == 1) return 1;
    else return n * factorial(n - 1);
    
}


Console.WriteLine(factorial(num));