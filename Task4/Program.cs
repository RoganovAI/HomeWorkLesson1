
Random rnd = new Random();
int[] numbers = new int[10];
int min = 999;
int summ = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, 100);
}

foreach (int number  in numbers)
{
    if (min > number) min = number;
    summ += number;

    Console.WriteLine(number);
}

Console.WriteLine($"Минимальное значение: {min}, среднее значение: {summ / numbers.Length}");