
Console.Clear();

string result = "";
bool isReminderOf_3, isRemainderOf_5;

for (int i = 1; i <= 100; i++)
{
    isReminderOf_3 = i % 3 == 0;
    isRemainderOf_5 = i % 5 == 0;

    if (isReminderOf_3 && isRemainderOf_5)
    {
        result += "FizzBuzz ";
    }
    else if (isReminderOf_3)
    {
        result += "Fizz ";
    }
    else if (isRemainderOf_5)
    {
        result += "Buzz ";
    }
    else
    {
        result += i + " ";
    }

}

Console.WriteLine(result);