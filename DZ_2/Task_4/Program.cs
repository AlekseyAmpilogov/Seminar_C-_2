int num1 = new Random().Next(1, 1000000); 
Console.WriteLine(num1); 
int num2 = 7;
int num3 = 23;

if (num1 % num2 == 0 && num1 % num3 == 0)
{
    Console.WriteLine ("Число " + num1 + " кратно числам " + num2 + " и " + num3);
}
else 
{
    Console.WriteLine ("Число " + num1 + " не кратно числам " + num2 + " и " + num3);
}