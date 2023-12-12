// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.


    
       using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
        {
            return -1; // проверка на положительность числа
        }
    }

    static void Main(string[] args)
    {
        int m = 2; // Возьмём в пример самые простые числа, чтобы не ломать себе мозг
        int n = 1; 
        int result = Ackermann(m, n);
        Console.WriteLine("Ackermann({0}, {1}) = {2}", m, n, result);
    }
}


