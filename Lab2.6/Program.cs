using System;
class ArrayExample
{
    static void Main()
    {
        int L;
        Console.WriteLine("Введите размер массива:");
        while (!int.TryParse(Console.ReadLine(), out L))                //проверка на ввод переменных
        {
            Console.WriteLine("Ошибка ввода! Введите целое число L");
        }
        int[] a = new int[L];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = i+1;
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"a[{i+1}] = {a[i]}");
        }
    }
}