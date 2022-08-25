// Задача 66: Задайте значения M и N. Напишите рекурсионный метод, 
// который найдёт сумму натуральных элементов в промежутке от M до N.

void Zadacha66(int m, int n, int sum = 0)
{
    if (m == n + 1)
    {
        Console.WriteLine(sum);
        return;
    }

    sum += m;
    m++;
    Zadacha66(m, n, sum);
}
Zadacha66(1, 15);

