// 75. Есть два массива info и data. 
// Массив data состоит из нулей и единиц, хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей. 
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 
// Пример:  входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:  1, 7, 0, 1

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0};
int[] info = { 2, 3, 3, 1, 4, 2};
if (info.Sum() != data.Length) 
{
    Console.WriteLine ("число элементов массива data не соотвествует массиву info");
    Environment.Exit(1);
}
int[] rezultArray = new int [info.Length];
int startIndex = 0;
for (int i = 0; i < info.Length; i++)
{
    int endIndex = startIndex + info[i] - 1;
    int newElement = 0;
    int degree = 0;
    for (int j = endIndex; j >= startIndex; j--) 
    {
        if (data[j] == 1)
            newElement += Convert.ToInt32(Math.Pow(2, degree));
        degree++;
    }
    rezultArray [i] = newElement;
    startIndex += info[i];
}
PrintArray(rezultArray);


