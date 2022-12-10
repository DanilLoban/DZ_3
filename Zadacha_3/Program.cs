// See https://aka.ms/new-console-template for more information
Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++) Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");