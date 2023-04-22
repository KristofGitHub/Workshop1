// Задача 1 (которая Задача 2): Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("   ");
Console.WriteLine("*  *   *");
Console.WriteLine("Задача 1 (которая Задача 2): Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("   ");
Console.WriteLine("Введите число #1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число #2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) Console.WriteLine($"Большее - число #1, равное {num1}. Меньшее - число #2, равное {num2}");
if (num2 > num1) Console.WriteLine($"Большее - число #2, равное {num2}. Меньшее - число #1, равное {num1}");
if (num2 == num1) Console.WriteLine($"Число #1 и число #2 равны.");

// Задача 2 (которая Задача 4): Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("   ");
Console.WriteLine("*  *   *");
Console.WriteLine("Задача 2 (которая Задача 4): Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("   ");
Console.WriteLine("Введите число #1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число #2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число #3: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (n1 > max) max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3; 

Console.WriteLine($"Наибольшее из трёх чисел равно {max}.");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("   ");
Console.WriteLine("*  *   *");
Console.WriteLine("Задача 3 (которая Задача 6): Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine("   ");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) Console.WriteLine($"Введённое число {number} является чётным.");
else Console.WriteLine($"Введённое число {number} является нечётным.");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
