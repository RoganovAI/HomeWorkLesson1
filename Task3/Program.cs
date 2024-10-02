
int[] numbers = [1, 2, 3, 4, 5];
int[] numbersClone = new int[5];
int i = 0;

void ShowArray(int[] argArray)
{
    for (int i = 0; i < argArray.Length; i++)
    {
        Console.WriteLine(argArray[i]);
    }
}

while (i < numbers.Length)
{
    numbersClone[i] = numbers[i];
    i++;
}

ShowArray(numbers);
Console.WriteLine("-----");
ShowArray(numbersClone);
