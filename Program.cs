// задача 34

/*int[] array = GetArray(6, 100, 999);
Console.WriteLine(string.Join(" ", array));

int count = 0;
for (int i = 0; i < array.Length; i++){

if (array[i] % 2 == 0) {
count += 1;
}
}
Console.WriteLine($"Колличество четных чисел = {count}");

int[] GetArray(int size, int minValue, int maxVolue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxVolue + 1);
    }
    return res;
}*/

// Задача 36

/*int[] array = GetArray(5, -100, 100);
Console.WriteLine(string.Join(" ", array));

int summ = 0;
for (int i = 0; i < array.Length; i++)
{
if (i % 2 != 0) {
summ += array[i];
}
}
Console.WriteLine($"Сумма по нечетным позициям = {summ}");


int[] GetArray(int size, int minValue, int maxVolue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxVolue);
    }
    return res;
}*/

// Задача 38

/*int[] array = GetArray(5, 1, 50);
Console.WriteLine(string.Join(" ", array));*/

double[] array = new double[10];
for(int i = 0; i < 10; i++)
{
    double x =new Random().NextDouble();
    array[i] = Math.Round(x*(99-10) + 10, 3);
}
Console.WriteLine(string.Join(" ", array));

double max = array[0];
double min = array[0];
double rez = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }

   if (array[i] > max)
    {
        max = array[i];
    }
}

    rez = max - min;

Console.WriteLine($"Разница = {rez}");


/*int[] GetArray(int size, int minValue, int maxVolue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxVolue);
    }
    return res;
}*/