Start:

Console.Write("Введите делитель = "); 
int num1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите делимое = "); 
int num2 = int.Parse(Console.ReadLine());
int rem = 0;

if (num2 % num1 == 0)
{
    Console.WriteLine ("Число " + num2 + " кратно числу " + num1);
}
else 
{
    rem = num2 % num1;
    Console.WriteLine ("Число " + num2 + " не кратно числу " + num1 + " при делении остаток равен " + rem);
}

goto Start;
