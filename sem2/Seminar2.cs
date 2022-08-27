int value = new Random().Next();
int power = 1;
while (value / power > 1000) power *= 10;
if (value > 99) Console.WriteLine($"third digit of {value} is {value / power % 10}");
else Console.WriteLine($"there isn't third digit in {value}");
