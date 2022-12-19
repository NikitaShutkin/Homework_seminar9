// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N большее M: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма чисел от {M} до {N} равна {SummaRec(M, N)}");
int SummaRec(int M, int N)
{
    if (M == N) return M;
    return N + (SummaRec(M, N - 1)); // в себе прячем sum+=N и N--
}

