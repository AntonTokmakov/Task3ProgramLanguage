Console.WriteLine("Введите число, желательно трехзначеное");
int number = int.Parse(Console.ReadLine());
int thirdNumber = ThirdDigit(number);

if (thirdNumber == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {number} равна {thirdNumber}");
}

int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}