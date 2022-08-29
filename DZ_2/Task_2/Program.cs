int rand = new Random().Next(1, 65536);
Console.WriteLine(rand);
if (rand > 99)
{
    Console.WriteLine(rand.ToString() [2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет!!!");
}