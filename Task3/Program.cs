Console.WriteLine("Введите номер дня недели");

int weekNumber = int.Parse(Console.ReadLine());

if (weekNumber >= 1 && weekNumber <= 5)
{
    Console.WriteLine("Нет");
}
if (weekNumber >= 6 && weekNumber <= 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("В неделе 7 дней");
}