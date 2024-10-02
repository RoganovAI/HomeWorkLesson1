
Console.Clear();
Console.WriteLine("Введите номер месяца");

var key = Console.ReadLine();
int numericValue;
bool isNumber = int.TryParse(key, out numericValue);

if (!isNumber)
{
    Console.WriteLine("Значение не является числом");
    return;
}

if (numericValue < 1 || numericValue > 12)
{
    Console.WriteLine("Число должно находиться в диапвзоне от 1 до 12");
    return;
}

Console.WriteLine((Month)numericValue);

enum Month
{
    Январь = 1,
    Февраль,
    Март,
    Апрель,
    Май,
    Июнь,
    Июль,
    Август,
    Сентябрь,
    Октябрь,
    Ноябрь,
    Декабрь
}

