// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"You are input {num} number");

// Task_1: take number and output nember*numer
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"You are input {num*num} number");

// Task_2: Является ли первое число квадратом второго?
// Console.WriteLine("Input 1st number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input 2nd number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2*num2 == num1){
//     Console.WriteLine($"Число {num1} является квадратом числа {num2}");
// }else{
//     Console.WriteLine($"Число {num1} НЕ является квадратом числа {num2}");
// }

// Task_3: Принимаем N и выдаем последовательность от -N до N.
Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = -N;
while (M != N + 1){
    Console.WriteLine(M);
    M++;
}

