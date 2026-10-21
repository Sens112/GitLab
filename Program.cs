using System;

public class Program
{
    static long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException(
                "Число не може бути від'ємним.");

        long result = 1;

        for (int i = 2; i <= n; i++)
        {
            checked
            {
                result *= i;
            }
        }

        return result;
    }

    static void Main()
    {
        //Console.InputEncoding = Encoding.UTF8;
        //Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введіть ціле невід'ємне число: ");

        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Помилка: введіть ціле число.");
            return;
        }

        try
        {
            Console.WriteLine($"{n}! = {Factorial(n)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        catch (OverflowException)
        {
            Console.WriteLine(
                "Помилка: результат перевищує допустимий діапазон long.");
        }
    }
}