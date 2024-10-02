
Random rnd = new Random();
int arrLength = rnd.Next(5, 15);

int[] numbers = CreateMyArray(arrLength);
Reverse(numbers);
PrintArray(numbers);

int[] CreateMyArray(int arrLength)
{
    int[] result = new int[arrLength];

    for (int i = 0; i < arrLength; i++)
    {
        result[i] = i;
    }

    return result;
}

void Reverse(int[] arr)
{
    int temp;
    int arrLastIndex = arr.Length - 1;
    int middle = arr.Length / 2;
    
    for (int i = 0; i < middle; i++)
    {
        temp = arr[i];
        arr[i] = arr[arrLastIndex - i];
        arr[arrLastIndex - i]  = temp;
    }
}

void PrintArray(int[] arr)
{
    foreach (int i in arr)
    {
        Console.WriteLine(i);
    }
}