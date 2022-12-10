// Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 7
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max)
{
    max = num_3;
} 
    Console.WriteLine("Максимальное из трех чисел -> ");

