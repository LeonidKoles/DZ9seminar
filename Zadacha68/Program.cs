// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Zadacha68(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > n && n == 0) return Zadacha68(m - 1, 1);
    if (m > n && n > 0) return Zadacha68(m - 1, Zadacha68(m, n - 1));
    return n + 1;
    Console.WriteLine(Zadacha68(m, n));
    Zadacha68(m,n);


}
Zadacha68(1, 2);