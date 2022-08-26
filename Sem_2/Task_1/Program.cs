Console.Write("Введите делимое = "); 
int num1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите делитель = "); 
int num2 = int.Parse(Console.ReadLine());
int rem = 0;

if (num1 % num2 == 0)
{
    Console.WriteLine ("Число " + num1 + " кратно числу " + num2);
}
else 
{
    rem = num1 % num2;
    Console.WriteLine ("Число " + num1 + " не кратно числу " + num2 + " при делении остаток равен " + rem);
}