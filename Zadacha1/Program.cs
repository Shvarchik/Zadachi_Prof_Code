// Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые
// делятся на k, но не на l
// делятся хотябы на k или на l
// не делятся на (k + l)
(int Count1, int Count2, int Count3) СonditionsCheck(int n, int k, int l)
{
    int Count1 = 0;
    int Count2 = 0;
    int Count3 = 0;

    for (int i = 1; i <= n; i++)
    {
        // if (i % k == 0 && i % l != 0)
        //     Count1++;
        // if (i % k == 0 || i % l == 0)
        //     Count2++;
        if (i % l == 0)
            Count2++;
        else if (i % k == 0)
        {
            Count2++;
            Count1++;
        }
        if ((i % (k + l)) != 0)
            Count3++;
    }
    return (Count1, Count2, Count3);
}
Console.Write("Введите максимальное число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k: ");
int k = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите l: ");
int l = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{СonditionsCheck(n, k, l).Item1} чисел делятся на {k}, но не на {l}");
Console.WriteLine($"{СonditionsCheck(n, k, l).Item2} чисел делятся хотя бы на {k} или на {l}");
Console.WriteLine($"{СonditionsCheck(n, k, l).Item3} чисел не делятся на {k}+{l}");