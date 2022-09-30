// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Число N = ");
int The_N_Number = int.Parse(Console.ReadLine());

int Temp_Num = 0;


Console.Write("Result = ");
while (Temp_Num <= The_N_Number)
{
    if (Temp_Num != 0) { if (Temp_Num % 2 == 0) { Console.Write(Temp_Num); Console.Write(", "); } }
    Temp_Num += 1;
}



