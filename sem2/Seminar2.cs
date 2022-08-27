int value = new Random().Next(100000);
int power = 1;
while (value / power > 0) power *= 10;
if (value > 99) Console.WriteLine($"third digit of {value} is {value / (power / 1000) % 10}");
else Console.WriteLine($"there isn't third digit in {value}");
