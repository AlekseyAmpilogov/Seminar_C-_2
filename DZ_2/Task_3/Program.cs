Start:

Console.WriteLine ("Введите цифру, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day ==7)
{
    Console.WriteLine("Это выходной день!");
}
else 
    if (day < 1 || day > 7)
    {
        Console.WriteLine("Это не день недели!");
    }
else 
    if (day > 0 && day < 6)
    {
        Console.WriteLine("Это рабочий день!");
    }

goto Start;