// Разложите натуральное число n на простые множители и определите
// сколько раз встречается множитель 2 в произведении
// наименьший множитель произведения
// сколько различных множителей в произведении

int MinDivisor(int n)
{
    int mindiv = 1;
    for (int i = 2; i <= n; i++)
    {
        if (n % i == 0)
        {
            mindiv = i;
            return mindiv;
        }
    }
    return mindiv;
}

int CountOfTwo(int n)
{
    int count2 = 0;
    while (n % 2 == 0)
    {
        n = n / 2;
        count2++;
    }
    return count2;
}

int NumberOfUniqDivisors(int n)
{
    int divisor = 2;
    int count = 0;
    // int marker = 0;  все заккоментированное может быть вместо строк 42-43
    while (n > 1)
    {
        while (n % divisor == 0)
        {
            n = n / divisor;
            //      marker = 1;
            if (n % divisor != 0)
                count++;
        }
        //  if (marker == 1)
        //  {
        //      count++;
        //      marker = 0;
        //  } 
        divisor++;
    }
    return count;
}
int n = new Random().Next(90, 91);
Console.WriteLine(n);

int countOfTwo = CountOfTwo(n);
if (countOfTwo > 0) Console.WriteLine($"множитель 2 встречается {countOfTwo} раз");
else Console.WriteLine("множитель 2 не встречается");

Console.WriteLine($"наименьший делитель {MinDivisor(n)}");

int countUniqs = NumberOfUniqDivisors(n);

Console.WriteLine($"колличество уникальных множителей {countUniqs}");


