int rand = new Random().Next(100, 1000);
Console.WriteLine(rand);
int first_digit = rand / 100;
int last_digit = rand % 10;
Console.WriteLine(first_digit.ToString() + last_digit.ToString());