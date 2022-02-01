// Разложите натуральное число n на простые множители и определите
// сколько раз встречается множитель 2 в произведении
// наименьший множитель произведения
// сколько различных множителей в произведении

int n = new Random().Next(90,91);
Console.WriteLine(n);
Console.WriteLine($"наименьший делитель {Min(n)}");
int count2 = 0;
while (n%2 == 0)
{
    n = n/2;
    count2++;
}
if (count2>0) Console.WriteLine($"множитель 2 встречается {count2}");

int delitel = 3;
int count = 0;
// int marker = 0;  все заккоментированное может быть вместо строк 26-27
while (n>1)
{
    while (n%delitel == 0)
    {
        n= n/delitel;
//      marker = 1;
        if (n%delitel!=0) 
            count++;
    }
//  if (marker == 1)
//  {
//      count++;
//      marker = 0;
//  } 
    delitel++;
}

Console.WriteLine($"колличество уникальных множителей = {count + count2}");

int Min(int n)
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


