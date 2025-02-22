﻿/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int rec(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return rec(m - 1, 1);
  else return rec(m - 1, rec(m, n - 1));
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = {rec(m, n)}");