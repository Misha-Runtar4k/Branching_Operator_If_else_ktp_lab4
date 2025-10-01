using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть значення a (int): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введіть значення x (int): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введіть значення t (int): ");
        int t = int.Parse(Console.ReadLine());

        Console.Write("Введіть значення c (float): ");
        float c = float.Parse(Console.ReadLine());

        Console.Write("Введіть нижню межу діапазону: ");
        double low = double.Parse(Console.ReadLine());

        Console.Write("Введіть верхню межу діапазону: ");
        double high = double.Parse(Console.ReadLine());

        int вираз1 = -a * x * t;
        double вираз2 = a + x / 2;
        float вираз3 = c * a + x / 4;

        Console.WriteLine($"\nРезультати обчислень:");
        Console.WriteLine($"Вираз 1 (int)   = {вираз1}");
        Console.WriteLine($"Вираз 2 (double)= {вираз2}");
        Console.WriteLine($"Вираз 3 (float) = {вираз3}");

        Console.WriteLine("\nПеревірка діапазону:");

        if (вираз1 >= low && вираз1 <= high)
            Console.WriteLine($"вираз 1 = {вираз1} входить у діапазон");
        else
            Console.WriteLine($"Вираз 1 = {вираз1} НЕ входить у діапазон");

        if (вираз2 >= low && вираз2 <= high)
            Console.WriteLine($"Вираз 2 = {вираз2} входить у діапазон");
        else
            Console.WriteLine($"Вираз 2 = {вираз2} НЕ входить у діапазон");

        if (вираз3 >= low && вираз3 <= high)
            Console.WriteLine($"Вираз3 = {вираз3} входить у діапазон");
        else
            Console.WriteLine($"Вираз 3 = {вираз3} НЕ входить у діапазон");

        Console.WriteLine("\nПрограма завершена.");
    }
}