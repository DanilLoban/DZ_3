// See https://aka.ms/new-console-template for more information
Console.Write("Введите пятизначное число, ");
int N = Convert.ToInt32(Console.ReadLine());
if ((N >= 10000) & (N <= 100000))
{
    int b = N / 10000;
    int c = N % 10;
    if(b == c)
    {
        N = N / 10;
        int d = N % 1000;
        int e1 = d / 100;
        int e = N % 10;
        if(e1 == e)
        {
            Console.Write("палиндромом");
        }
        else
        {
            Console.Write("не палиндромом");
        }
    }
    else
    {
        Console.Write("не палиндромом");
    }
}
else 
{
    Console.Write("введено не 5 цифр");
}
