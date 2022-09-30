// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


int MAX = 0;
int MIN = 0;


Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());


if (A > B)
{
    MAX = A;
    Console.Write("MAX = ");
    Console.WriteLine(A);

    MIN = B;
    Console.Write("MIN = ");
    Console.WriteLine(B);
}
else
{
    MAX = B;
    Console.Write("MAX = ");
    Console.WriteLine(B);

    MIN = A;
    Console.Write("MIN = ");
    Console.WriteLine(A);
}