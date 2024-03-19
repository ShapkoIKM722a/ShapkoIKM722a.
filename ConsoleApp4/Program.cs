

using System;

class Program
{
    

    static void Main()
    {
        /*Перша задача: Напишіть програму, яка перевіряє, чи є введене користувачем число
         простим.Використовуйте арифметичні операції для перевірки дільників
         числа.*/

        Console.WriteLine("Task 1");
        Console.WriteLine("Enter a prime number:");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    

    /*Друга задача: Напишіть програму, яка перевіряє, чи належить введене користувачем
число заданому інтервалу.Використовуйте логічні оператори для перевірки
умови належності числа до інтервалу.*/

    Console.WriteLine("\nTask 2");
        Console.WriteLine("Enter the number to check:");
        int numberToCheck = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the beginning of the interval:");
        int startInterval = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the end of the interval:");
        int endInterval = int.Parse(Console.ReadLine());

        if (IsNumberInRange(numberToCheck, startInterval, endInterval))
        {
            Console.WriteLine($"{numberToCheck} belongs to the interval from {startInterval} before {endInterval}.");
        }
        else
        {
            Console.WriteLine($"{numberToCheck} does not belong to the interval from {startInterval} before {endInterval}.");
        }

        /* Третя задача: Напишіть програму, яка знаходить мінімальний і максимальний
         елементи у масиві.*/

        Console.WriteLine("\nTask 3");
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Console.WriteLine($"Enter {size} numbers:");

        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        var minMax = FindMinMax(array);
        Console.WriteLine($"Minimum element in the array: {minMax.Item1}");
        Console.WriteLine($"Maximum element in the array: {minMax.Item2}");

        Console.ReadLine();
   
    }

    // Перша задача: перевірка, чи є введене число простим
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        if (num == 2)
            return true;
        if (num % 2 == 0)
            return false;

        
        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    // Друга задача: перевірка, чи належить введене число заданому інтервалу
    static bool IsNumberInRange(int number, int startInterval, int endInterval)
    {
        return number >= startInterval && number <= endInterval;
    }
    // Третя задача: пошук мінімального і максимального елементів в масиві
    static (int, int) FindMinMax(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array must not be empty or null.");
        }

        int min = array[0];
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
            if (array[i] > max)
                max = array[i];
        }

        return (min, max);
    }
}

